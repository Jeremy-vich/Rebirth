


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildMemberLeavingMessage : NetworkMessage
{

public const uint Id = 5346;
public uint MessageId
{
    get { return Id; }
}

public bool kicked;
        public double memberId;
        

public GuildMemberLeavingMessage()
{
}

public GuildMemberLeavingMessage(bool kicked, double memberId)
        {
            this.kicked = kicked;
            this.memberId = memberId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(kicked);
            writer.WriteVarLong(memberId);
            

}

public void Deserialize(IDataReader reader)
{

kicked = reader.ReadBoolean();
            memberId = reader.ReadVarUhLong();
            

}


}


}