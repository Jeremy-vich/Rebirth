


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ForgettableSpellDeleteMessage : NetworkMessage
{

public const uint Id = 1206;
public uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        public int[] spells;
        

public ForgettableSpellDeleteMessage()
{
}

public ForgettableSpellDeleteMessage(sbyte reason, int[] spells)
        {
            this.reason = reason;
            this.spells = spells;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(reason);
            writer.WriteShort((short)spells.Length);
            foreach (var entry in spells)
            {
                 writer.WriteInt(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

reason = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            spells = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 spells[i] = reader.ReadInt();
            }
            

}


}


}