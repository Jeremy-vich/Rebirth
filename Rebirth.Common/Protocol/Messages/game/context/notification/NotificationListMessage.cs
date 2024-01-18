


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class NotificationListMessage : NetworkMessage
{

public const uint Id = 3867;
public uint MessageId
{
    get { return Id; }
}

public int[] flags;
        

public NotificationListMessage()
{
}

public NotificationListMessage(int[] flags)
        {
            this.flags = flags;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)flags.Length);
            foreach (var entry in flags)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            flags = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 flags[i] = reader.ReadVarInt();
            }
            

}


}


}