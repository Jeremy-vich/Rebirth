using PetaPoco;
using Rebirth.Common.Network;
using Rebirth.World.Command;
using Rebirth.World.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World
{
    public class Starter
    {
        public int ServerId;
        private IServer _server = new();

        private static Database _database = new Database("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Auth;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False", "SqlServerDatabaseProvider");
        public static Database DatabaseAuth
        {
            get
            {
                lock (_database)
                {
                    return _database;
                }
            }
        }
        private static Database _databaseWorld = new Database("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jerem\\source\\repos\\Rebirth\\Rebirth\\World.mdf;Integrated Security=True", "SqlServerDatabaseProvider");
        public static Database DatabaseWorld
        {
            get
            {
                lock (_databaseWorld)
                {
                    return _databaseWorld;
                }
            }
        }

        public void Start(int serverId)
        {
            ServerId = serverId;

            ExperienceManager.Instance.Init();
            InteractivesManager.Instance.Init();
            CommandManager.Instance.Load();
            JailManager.Instance.Init();

            _server.Accepted += _server_Accepted;
            _ = _server.Start(555);

            DatabaseAuth.Execute($"UPDATE Server SET Statut = 3 WHERE Id = @0", serverId);
        }

        private void _server_Accepted(System.Net.Sockets.Socket sock)
        {
            ClientsManager.Instance.Add(new Models.Client(sock));
            Console.WriteLine($"[WORLD] Client Added !");
        }
    }
}
