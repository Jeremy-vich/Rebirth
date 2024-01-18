


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildInvitationStateRecrutedMessage : NetworkMessage
{

public const uint Id = 7992;
public uint MessageId
{
    get { return Id; }
}

public sbyte invitationState;
        

public GuildInvitationStateRecrutedMessage()
{
}

public GuildInvitationStateRecrutedMessage(sbyte invitationState)
        {
            this.invitationState = invitationState;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(invitationState);
            

}

public void Deserialize(IDataReader reader)
{

invitationState = reader.ReadSbyte();
            

}


}


}