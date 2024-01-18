


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeMountsStableRemoveMessage : NetworkMessage
{

public const uint Id = 5321;
public uint MessageId
{
    get { return Id; }
}

public int[] mountsId;
        

public ExchangeMountsStableRemoveMessage()
{
}

public ExchangeMountsStableRemoveMessage(int[] mountsId)
        {
            this.mountsId = mountsId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)mountsId.Length);
            foreach (var entry in mountsId)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            mountsId = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 mountsId[i] = reader.ReadVarInt();
            }
            

}


}


}