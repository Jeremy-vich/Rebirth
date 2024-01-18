


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ForgettableSpellsPreset : Preset
{

public const short Id = 2189;
public override short TypeId
{
    get { return Id; }
}

public Types.SpellsPreset baseSpellsPreset;
        public Types.SpellForPreset[] forgettableSpells;
        

public ForgettableSpellsPreset()
{
}

public ForgettableSpellsPreset(short id, Types.SpellsPreset baseSpellsPreset, Types.SpellForPreset[] forgettableSpells)
         : base(id)
        {
            this.baseSpellsPreset = baseSpellsPreset;
            this.forgettableSpells = forgettableSpells;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            baseSpellsPreset.Serialize(writer);
            writer.WriteShort((short)forgettableSpells.Length);
            foreach (var entry in forgettableSpells)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            baseSpellsPreset = new Types.SpellsPreset();
            baseSpellsPreset.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            forgettableSpells = new Types.SpellForPreset[limit];
            for (int i = 0; i < limit; i++)
            {
                 forgettableSpells[i] = new Types.SpellForPreset();
                 forgettableSpells[i].Deserialize(reader);
            }
            

}


}


}