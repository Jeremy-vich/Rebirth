


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ForgettableSpellListUpdateMessage : NetworkMessage
{

public const uint Id = 3380;
public uint MessageId
{
    get { return Id; }
}

public sbyte action;
        public Types.ForgettableSpellItem[] spells;
        

public ForgettableSpellListUpdateMessage()
{
}

public ForgettableSpellListUpdateMessage(sbyte action, Types.ForgettableSpellItem[] spells)
        {
            this.action = action;
            this.spells = spells;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(action);
            writer.WriteShort((short)spells.Length);
            foreach (var entry in spells)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

action = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            spells = new Types.ForgettableSpellItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 spells[i] = new Types.ForgettableSpellItem();
                 spells[i].Deserialize(reader);
            }
            

}


}


}