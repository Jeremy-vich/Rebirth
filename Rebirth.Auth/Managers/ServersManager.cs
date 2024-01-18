using PetaPoco;
using Rebirth.Auth.Frames;
using Rebirth.Auth.Models;
using Rebirth.Common.Extensions;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server = Rebirth.Auth.Models.Server;

namespace Rebirth.Auth.Managers
{
    public class ServersManager : DataManager<ServersManager>
    {
        public List<uint>? Get(string username)
        {
            var acc = IdentificationManager.Instance.Get(username);
            if (acc == null)
                return null;

            List<uint> list = new();
            foreach (var serv in Starter.Database.Fetch<Server>())
            {
                var db = new Database($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jerem\\source\\repos\\Rebirth\\Rebirth\\{serv.Base}.mdf;Integrated Security=True", "SqlServerDatabaseProvider");
                if (db.Single<sbyte>("SELECT COUNT(Id) FROM Character WHERE AccountId = @0", acc.Id) > 0)
                    list.Add(serv.Id);
            }
            return list;
        }

        public List<Common.Protocol.Data.Server> _d2oServers = ObjectDataManager.GetAll<Common.Protocol.Data.Server>();

        public Server? Get(short id) => Starter.Database.SingleOrDefault<Server>(id);

        public void Send(Client client)
        {
            //List<GameServerInformations> list = new ();
            //foreach (var serv in Starter.Database.Fetch<Server>())
            //{
            //    var db = new Database($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jerem\\source\\repos\\Rebirth\\Rebirth\\{serv.Base}.mdf;Integrated Security=True", "SqlServerDatabaseProvider");
            //    try
            //    {
            //        list.Add(new GameServerInformations(serv.Id, 0, (sbyte)serv.Statut, 0, true, db.Single<sbyte>("SELECT COUNT(Id) FROM Character WHERE AccountId = @0", client.Account.Id), 5, DateTime.Now.AddYears(-5).DateTimeToUnixTimestamp()));
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"[Auth.ServersManager] {ex.Message}");
            //    }
            //}
            //client.AddFrame(typeof(ServerFrame));
            //client.Send(new ServersListMessage(list.ToArray(), 0, true));
        }
    }
}
