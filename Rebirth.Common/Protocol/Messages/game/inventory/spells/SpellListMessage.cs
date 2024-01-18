


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class SpellListMessage : NetworkMessage
{

public const uint Id = 3146;
public uint MessageId
{
    get { return Id; }
}

public bool spellPrevisualization;
        public Types.SpellItem[] spells;
        

public SpellListMessage()
{
}

public SpellListMessage(bool spellPrevisualization, Types.SpellItem[] spells)
        {
            this.spellPrevisualization = spellPrevisualization;
            this.spells = spells;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(spellPrevisualization);
            writer.WriteShort((short)spells.Length);
            foreach (var entry in spells)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

spellPrevisualization = reader.ReadBoolean();
            var limit = (ushort)reader.ReadUShort();
            spells = new Types.SpellItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 spells[i] = new Types.SpellItem();
                 spells[i].Deserialize(reader);
            }
            

}


}


}