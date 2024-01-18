


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildJoinedMessage : NetworkMessage
{

public const uint Id = 630;
public uint MessageId
{
    get { return Id; }
}

public Types.GuildInformations guildInfo;
        public uint rankId;
        

public GuildJoinedMessage()
{
}

public GuildJoinedMessage(Types.GuildInformations guildInfo, uint rankId)
        {
            this.guildInfo = guildInfo;
            this.rankId = rankId;
        }
        

public void Serialize(IDataWriter writer)
{

guildInfo.Serialize(writer);
            writer.WriteVarInt((int)rankId);
            

}

public void Deserialize(IDataReader reader)
{

guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
            rankId = reader.ReadVarUhInt();
            

}


}


}