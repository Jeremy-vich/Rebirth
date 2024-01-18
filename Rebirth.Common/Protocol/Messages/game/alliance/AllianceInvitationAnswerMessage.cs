


















// Generated on 01/30/2023 13:09:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceInvitationAnswerMessage : NetworkMessage
{

public const uint Id = 3792;
public uint MessageId
{
    get { return Id; }
}

public bool accept;
        

public AllianceInvitationAnswerMessage()
{
}

public AllianceInvitationAnswerMessage(bool accept)
        {
            this.accept = accept;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(accept);
            

}

public void Deserialize(IDataReader reader)
{

accept = reader.ReadBoolean();
            

}


}


}