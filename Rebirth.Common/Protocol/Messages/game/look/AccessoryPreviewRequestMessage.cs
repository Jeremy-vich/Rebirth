


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AccessoryPreviewRequestMessage : NetworkMessage
{

public const uint Id = 7170;
public uint MessageId
{
    get { return Id; }
}

public uint[] genericId;
        

public AccessoryPreviewRequestMessage()
{
}

public AccessoryPreviewRequestMessage(uint[] genericId)
        {
            this.genericId = genericId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)genericId.Length);
            foreach (var entry in genericId)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            genericId = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 genericId[i] = reader.ReadVarUhInt();
            }
            

}


}


}