using Rebirth.Common.Network;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Timers;
using Rebirth.Common.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Common.Dispatcher
{
    public class DispatcherCore
    {
        #region Var
        private Dictionary<uint, MethodHandler> methods;
        private Queue<NetworkMessage> msgQueue;
        private Task executionTask;
        private System.Timers.Timer timer;
        private IClient client;
        private Logger _logger;
        #endregion

        #region Constructor
        public DispatcherCore(IClient client)
        {
            this.client = client;
            _logger = LogManager.GetLoggerClass();
            methods = new Dictionary<uint, MethodHandler>();
            msgQueue = new Queue<NetworkMessage>();
            timer = new System.Timers.Timer(50);
            timer.Elapsed += Execute;
            timer.Start();
        }
        #endregion

        #region Private Methods
        private void Execute(object sender, System.Timers.ElapsedEventArgs args)
        {
            lock (msgQueue)
            {
                if (msgQueue.Count <= 0)
                    return;
                var actualMessage = msgQueue.Dequeue();
                if (methods.ContainsKey(actualMessage.MessageId))
                    methods[actualMessage.MessageId].Invoke(actualMessage, client);
                else
                    Console.WriteLine(string.Format("Unknow treatment for : {0}", actualMessage.ToString().Split('.').Last()));
            }
        }
        #endregion

        #region Public Methods
        public void Stop()
        {
            timer.Stop();
        }
        public void RegisterFrame(Type type)
        {
            object obj = Activator.CreateInstance(type);
            foreach (var methodInfo in type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy))
            {
                MessageHandlerAttribute[] attributes = methodInfo.GetCustomAttributes<MessageHandlerAttribute>().ToArray();
                if (attributes.Length != 0)
                {
                    ParameterInfo[] parameters = methodInfo.GetParameters();
                    if (parameters.Length != 2)
                    {
                        throw new Exception(string.Format("Only two parameters is allowed to use the MessageHandler attribute. (method {0})", methodInfo.Name));
                    }

                    methods.Add(attributes.First().MessageId, new MethodHandler(methodInfo, obj, attributes));
                }
            }
        }

        public void UnRegisterFrame(Type type)
        {
            object obj = Activator.CreateInstance(type);
            foreach (var methodInfo in type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy))
            {
                MessageHandlerAttribute[] attributes = methodInfo.GetCustomAttributes<MessageHandlerAttribute>().ToArray();
                if (attributes.Length != 0)
                {
                    ParameterInfo[] parameters = methodInfo.GetParameters();
                    if (parameters.Length != 2)
                    {
                        throw new Exception(string.Format("Only two parameters is allowed to use the MessageHandler attribute. (method {0})", methodInfo.Name));
                    }

                    methods.Remove(attributes.First().MessageId);
                }
            }
        }

        public void Dispatch(NetworkMessage msg)
        {
            msgQueue.Enqueue(msg);
        }
        #endregion
    }
}
