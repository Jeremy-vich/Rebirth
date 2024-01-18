


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildFactsRequestMessage : NetworkMessage
{

public const uint Id = 1622;
public uint MessageId
{
    get { return Id; }
}

public uint guildId;
        

public GuildFactsRequestMessage()
{
}

public GuildFactsRequestMessage(uint guildId)
        {
            this.guildId = guildId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)guildId);
            

}

public void Deserialize(IDataReader reader)
{

guildId = reader.ReadVarUhInt();
            

}


}


}