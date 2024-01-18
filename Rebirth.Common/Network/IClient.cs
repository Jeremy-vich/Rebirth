using Rebirth.Common.Dispatcher;
using Rebirth.Common.Extensions;
using Rebirth.Common.IO;
using System.Net.Sockets;
using System.Timers;

namespace Rebirth.Common.Network
{
    public class IClient
    {
        private Socket _sock;
        private const int BUFFER_SIZE = 1024;
        private byte[] _buffer = new byte[BUFFER_SIZE];
        private SocketAsyncEventArgs _receiveEvent = new();
        private SocketAsyncEventArgs _disconectEvent = new();
        private DispatcherCore _dispatcher;
        private object _lock = new();

        private System.Timers.Timer _timer = new(1000);

        private TimeSpan _conTime = DateTime.Now.TimeOfDay;
        private TimeSpan _lastPacket;
        private List<TimeSpan> _packetsTime = new();
        private double _flood { get
            {
                var fll = 0d;
                _packetsTime.ForEach((x) => {
                    fll += x.TotalSeconds;
                });
                return (fll - _conTime.TotalSeconds) / _packetsTime.Count;
            } } 

        public IClient(Socket sock)
        {
            _sock = sock;

            _receiveEvent = new();
            _receiveEvent.SetBuffer(_buffer, 0, _buffer.Length);
            _receiveEvent.Completed += ReceiveEvent_Completed;

            _sock.ReceiveAsync(_receiveEvent);

            _dispatcher = new(this);

            _timer.Elapsed += CheckDisconnect;
            _timer.Start();
        }

        protected virtual void ReceiveEvent_Completed(object sender, SocketAsyncEventArgs e)
        {
            do
            {
                lock (_lock)
                {
                    if (!_sock.IsConnected())
                        break;

                    var time = DateTime.Now.TimeOfDay - _lastPacket;
                    _packetsTime.Add(time);
                    _lastPacket = DateTime.Now.TimeOfDay;

                    if (_packetsTime.Count > 10 && _flood < 0.2)
                    {
                        Console.WriteLine("[Alert] Client disconnected by anti-flood !");
                        Disconnect();
                    }


                    MessagePart currentMessage = new();
                    BigEndianReader reader = new(_buffer);
                    if (currentMessage.Build(reader))
                    {
                        var messageDataReader = new BigEndianReader(currentMessage.Data);

                        NetworkMessage message = MessageReceiver.BuildMessage((uint)currentMessage.MessageId, messageDataReader);
                        if (message == null)
                            return;

                        _dispatcher.Dispatch(message);
                        Console.WriteLine("[Receive] " + message.ToString().Split('.').Last());
                    }
                }

            } while (!_sock.ReceiveAsync(_receiveEvent));
        }

        public virtual void CheckDisconnect(object sender, ElapsedEventArgs args)
        {
            if (_sock.IsConnected())
                return;
            _timer.Stop();
            Disconnect();
        }

        public virtual void Disconnect()
        {
            _dispatcher.Stop();
            _sock.Disconnect(false);
        }

        public void Send(NetworkMessage msg)
        {
            lock (_lock)
            {
                if (!_sock.IsConnected())
                return;

                var writer = new BigEndianWriter();
                MessagePacking pack = new MessagePacking();
                pack.Pack(msg, writer);
                Console.WriteLine("[Send] {0}", msg.ToString().Split('.').Last());


                try
                {
                    _sock.Send(writer.Data);
                }
                catch (SocketException ex)
                {

                    Console.WriteLine($"[Socket] {ex.Message}");
                }
            }
        }

        public string IP { get { return _sock.RemoteEndPoint.ToString().Split(':').First(); } } 
        public void AddFrame(Type type) => _dispatcher.RegisterFrame(type);
        public void RemoveFrame(Type type) => _dispatcher.UnRegisterFrame(type);
    }
}
