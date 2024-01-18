using Rebirth.Common.Extensions;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.GameData.Maps;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Managers;
using Rebirth.World.Pathfinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Models
{
    public class MonsterGroup
    {
        public double id { get; set; }
        public List<Monster> Monsters { get; set; } = new List<Monster>();
        public uint CellId { get; set; }
        public DirectionsEnum Direction { get; set; } = DirectionsEnum.DIRECTION_SOUTH_EAST;

        public MonsterGroup(Map map, double id, uint cellid) {
            if (string.IsNullOrEmpty(map.MonstersMap.Datas))
                return;
            this.id = id * -1000;
            CellId = cellid;
            var number = new Random().Next(1, 8);
            var mons = map.MonstersMap.Datas.Remove(map.MonstersMap.Datas.Length - 1, 1).Split(';').Select(x =>  string.IsNullOrEmpty(x) ? null : ObjectDataManager.Get<Monster>(uint.Parse(x))).ToList();
            for (int i = 0; i < number; i++)
            {

                var rdn = new Random().Next(0, mons.Count - 1);
                if (mons[rdn] is null)
                    continue;
                Monsters.Add(mons[rdn]);
            }
        }

        public GameRolePlayGroupMonsterInformations GameRolePlayGroupMonsterInformations { get
            {
                var staticGroup = new GroupMonsterStaticInformations(new MonsterInGroupLightInformations(Monsters.First().id, 1), MonsterInGroupInformations);
                return new GameRolePlayGroupMonsterInformations(
                    id, 
                    new EntityLook(Monsters.First().look).GetEntityLook(), 
                    new EntityDispositionInformations((short)CellId, (sbyte)Direction), 
                    false, 
                    false,
                    false, 
                    staticGroup,
                    DateTime.Now.DateTimeToUnixTimestamp(), 
                    60000, 
                    -1, 
                    -1);
            } }

        public MonsterInGroupInformations[] MonsterInGroupInformations { get {
                return Monsters.Select(x => new MonsterInGroupInformations()
                {
                    creatureGenericId = x.id,
                    grade = 1,
                    look = new EntityLook(x.look).GetEntityLook()
                }).ToArray(); } }
    }
}
