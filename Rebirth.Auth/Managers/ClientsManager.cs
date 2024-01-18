using Rebirth.Auth.Models;
using Rebirth.Common.Extensions;
using Rebirth.Common.Network;
using Rebirth.Common.Protocol.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Auth.Managers
{
    public class ClientsManager : DataManager<ClientsManager>
    {
        private List<Client> _clients = new();

        public Client? Get(Func<Client, bool> predicate) => _clients.FirstOrDefault(predicate);
        public void Remove(Client client)
        {
            _clients.Remove(client);
            Console.WriteLine($"[Auth] Client disconnected !");
        }

        public void Add(Client client) => _clients.Add(client);

    }
}
