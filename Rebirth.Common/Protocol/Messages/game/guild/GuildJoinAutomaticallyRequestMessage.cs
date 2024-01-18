


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildJoinAutomaticallyRequestMessage : NetworkMessage
{

public const uint Id = 7374;
public uint MessageId
{
    get { return Id; }
}

public int guildId;
        

public GuildJoinAutomaticallyRequestMessage()
{
}

public GuildJoinAutomaticallyRequestMessage(int guildId)
        {
            this.guildId = guildId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(guildId);
            

}

public void Deserialize(IDataReader reader)
{

guildId = reader.ReadInt();
            

}


}


}