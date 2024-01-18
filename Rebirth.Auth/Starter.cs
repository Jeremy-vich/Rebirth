using PetaPoco;
using Rebirth.Auth.Managers;
using Rebirth.Common.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Auth
{
    public class Starter
    {
        private IServer _server = new();

        public static Database Database = new Database("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Auth;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False", "SqlServerDatabaseProvider");

        public void Start()
        {
            _server.Accepted += _server_Accepted;
            _ = _server.Start(5555);
        }

        private void _server_Accepted(System.Net.Sockets.Socket sock)
        {
            ClientsManager.Instance.Add(new Models.Client(sock));
            Console.WriteLine($"[Auth] Client Added !");
        }
    }
}
