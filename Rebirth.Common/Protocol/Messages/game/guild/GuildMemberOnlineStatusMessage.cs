


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildMemberOnlineStatusMessage : NetworkMessage
{

public const uint Id = 3512;
public uint MessageId
{
    get { return Id; }
}

public double memberId;
        public bool online;
        

public GuildMemberOnlineStatusMessage()
{
}

public GuildMemberOnlineStatusMessage(double memberId, bool online)
        {
            this.memberId = memberId;
            this.online = online;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(memberId);
            writer.WriteBoolean(online);
            

}

public void Deserialize(IDataReader reader)
{

memberId = reader.ReadVarUhLong();
            online = reader.ReadBoolean();
            

}


}


}