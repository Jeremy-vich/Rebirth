


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HouseGuildShareRequestMessage : NetworkMessage
{

public const uint Id = 6884;
public uint MessageId
{
    get { return Id; }
}

public uint houseId;
        public int instanceId;
        public bool enable;
        public uint rights;
        

public HouseGuildShareRequestMessage()
{
}

public HouseGuildShareRequestMessage(uint houseId, int instanceId, bool enable, uint rights)
        {
            this.houseId = houseId;
            this.instanceId = instanceId;
            this.enable = enable;
            this.rights = rights;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)houseId);
            writer.WriteInt(instanceId);
            writer.WriteBoolean(enable);
            writer.WriteVarInt((int)rights);
            

}

public void Deserialize(IDataReader reader)
{

houseId = reader.ReadVarUhInt();
            instanceId = reader.ReadInt();
            enable = reader.ReadBoolean();
            rights = reader.ReadVarUhInt();
            

}


}


}