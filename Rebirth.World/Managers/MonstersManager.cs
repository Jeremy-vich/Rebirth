using Rebirth.Common.Extensions;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.Protocol.Data;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Managers
{
    public class MonstersManager : DataManager<MonstersManager>
    {
        public void Init() { }

        public Monster Get(uint id) => ObjectDataManager.Get<Monster>(id);

        public MonstersMap? Get(int mapId) => Starter.DatabaseWorld.FirstOrDefault<MonstersMap>("WHERE id=@0", mapId);
    }
}
