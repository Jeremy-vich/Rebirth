using Rebirth.Common.Network;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using Thrift.Server;
using Thrift.Transport;
using Zaap.Extensions;
namespace Zaap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var handler = new ThriftServiceHandler();
            var processor = new MyThriftService.Processor(handler);

            TServerTransport transport = new TServerSocket(448);
            TServer server = new TThreadPoolServer(processor, transport);

            ProcessStartInfo startInfo = new ProcessStartInfo("C:\\Users\\jerem\\AppData\\Local\\Ankama\\Dofus - Copie\\Dofus.exe");
            startInfo.ArgumentList.Add("port=448");
            startInfo.ArgumentList.Add("gameName=Dofus");
            startInfo.ArgumentList.Add("gameRelease=2.67.1");
            startInfo.ArgumentList.Add("instanceId=1");
            startInfo.ArgumentList.Add($"hash={new Random().RandomString(32)}");
            startInfo.ArgumentList.Add("canLogin=true");
            Process.Start(startInfo);

            server.Serve();
        }

        public class ThriftServiceHandler : MyThriftService.Iface
        {
            public string Connect(string gameName, string releaseName, int instanceId, string hash)
            {
                return "testticket";
            }

            public string Settings_get(string gameSession, string key)
            {
                return key switch
                {
                    "autoConnectType" => "1",
                    "language" => "fr",
                    "connectionPort" => "5555",
                    _ => "",
                };
            }

            public string UserInfo_get(string gameSession)
            {
                return "neross";
            }

            public string Auth_getGameTokenWithWindowId_get(string gameSession, int gameId, int windowId)
            {
                return "neross";
            }
        }
    }
}