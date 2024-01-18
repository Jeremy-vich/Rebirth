


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class JobBookSubscribeRequestMessage : NetworkMessage
{

public const uint Id = 1977;
public uint MessageId
{
    get { return Id; }
}

public sbyte[] jobIds;
        

public JobBookSubscribeRequestMessage()
{
}

public JobBookSubscribeRequestMessage(sbyte[] jobIds)
        {
            this.jobIds = jobIds;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)(ushort)jobIds.Length);
            foreach (var entry in jobIds)
            {
                 writer.WriteSbyte(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadVarInt();
            jobIds = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 jobIds[i] = reader.ReadSbyte();
            }
            

}


}


}