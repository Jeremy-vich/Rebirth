


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HavenBagPackListMessage : NetworkMessage
{

public const uint Id = 112;
public uint MessageId
{
    get { return Id; }
}

public sbyte[] packIds;
        

public HavenBagPackListMessage()
{
}

public HavenBagPackListMessage(sbyte[] packIds)
        {
            this.packIds = packIds;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)(ushort)packIds.Length);
            foreach (var entry in packIds)
            {
                 writer.WriteSbyte(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadVarInt();
            packIds = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 packIds[i] = reader.ReadSbyte();
            }
            

}


}


}