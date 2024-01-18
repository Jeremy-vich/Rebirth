using Rebirth.Common.Extensions;
using Rebirth.Common.Network;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Managers
{
    public class ClientsManager : DataManager<ClientsManager>
    {
        private List<Client> _clients = new();

        public Client? Get(Func<Client, bool> predicate) => _clients.FirstOrDefault(predicate);
        public List<Client> GetAll(Predicate<Client> predicate) => _clients.FindAll(predicate);
        public void Remove(Client client)
        {
            client.Character?.Map?.Exit(client);
            _clients.Remove(client);
            Console.WriteLine($"[World] Client disconnected !");
        } 
        public void Add(Client client) => _clients.Add(client);
        public Client Get(string name)=> _clients.FirstOrDefault(x => x.Character.Name.ToLower() == name.ToLower());
        public void Send(NetworkMessage msg) => _clients.ForEach((client) => client.Send(msg));
    }
}
