


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HouseTeleportRequestMessage : NetworkMessage
{

public const uint Id = 573;
public uint MessageId
{
    get { return Id; }
}

public uint houseId;
        public int houseInstanceId;
        

public HouseTeleportRequestMessage()
{
}

public HouseTeleportRequestMessage(uint houseId, int houseInstanceId)
        {
            this.houseId = houseId;
            this.houseInstanceId = houseInstanceId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)houseId);
            writer.WriteInt(houseInstanceId);
            

}

public void Deserialize(IDataReader reader)
{

houseId = reader.ReadVarUhInt();
            houseInstanceId = reader.ReadInt();
            

}


}


}