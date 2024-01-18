using PetaPoco;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Models
{
    [TableName("Spells")]
    public class Spell
    {
        public int Id { get; set; }
        public int SpellId { get; set; }
        public int CharacterId { get; set; }
        public int Level { get; set; }
        public int ShortCutPos { get; set; }

        [Ignore]
        public Common.Protocol.Data.Spell Template => ObjectDataManager.Get<Common.Protocol.Data.Spell>(SpellId);
        [Ignore]
        public SpellLevel SpellLevel => ObjectDataManager.Get<SpellLevel>(Template.spellLevels[Level - 1]);
        [Ignore]
        public SpellItem SpellItem => new SpellItem(SpellId, (short)Level);
    }
}
