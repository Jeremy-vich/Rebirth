using Rebirth.Common.Extensions;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Managers
{
    public class ItemsManager : DataManager<ItemsManager>
    {
        public List<Item> Get(int characterId) => Starter.DatabaseWorld.Fetch<Item>("WHERE CharacterId = @0", characterId);
        public void Save(Item item) => Starter.DatabaseWorld.Save(item);
        public void Delete(Item item) => Starter.DatabaseWorld.Delete(item);
    }
}
