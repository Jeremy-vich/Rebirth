using Rebirth.Common.Protocol.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rebirth.Common.Network
{
    public delegate void AcceptedSocket(Socket sock);
    public class IServer
    {
        private Socket _sock = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public event AcceptedSocket Accepted;

        public async Task Start(short port)
        {
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Loopback, port);
            _sock.Bind(localEndPoint);
            _sock.Listen(100);
            Console.WriteLine($"Server started on port {port}");
            do
            {
                var sock = await _sock.AcceptAsync();
                Accepted?.Invoke(sock);
            } while (true);
        }
    }
}
