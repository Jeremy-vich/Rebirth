


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HouseGuildRightsMessage : NetworkMessage
{

public const uint Id = 8887;
public uint MessageId
{
    get { return Id; }
}

public uint houseId;
        public int instanceId;
        public bool secondHand;
        public Types.GuildInformations guildInfo;
        public uint rights;
        

public HouseGuildRightsMessage()
{
}

public HouseGuildRightsMessage(uint houseId, int instanceId, bool secondHand, Types.GuildInformations guildInfo, uint rights)
        {
            this.houseId = houseId;
            this.instanceId = instanceId;
            this.secondHand = secondHand;
            this.guildInfo = guildInfo;
            this.rights = rights;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)houseId);
            writer.WriteInt(instanceId);
            writer.WriteBoolean(secondHand);
            guildInfo.Serialize(writer);
            writer.WriteVarInt((int)rights);
            

}

public void Deserialize(IDataReader reader)
{

houseId = reader.ReadVarUhInt();
            instanceId = reader.ReadInt();
            secondHand = reader.ReadBoolean();
            guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
            rights = reader.ReadVarUhInt();
            

}


}


}