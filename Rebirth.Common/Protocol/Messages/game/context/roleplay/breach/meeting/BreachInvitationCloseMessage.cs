


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BreachInvitationCloseMessage : NetworkMessage
{

public const uint Id = 3545;
public uint MessageId
{
    get { return Id; }
}

public Types.CharacterMinimalInformations host;
        

public BreachInvitationCloseMessage()
{
}

public BreachInvitationCloseMessage(Types.CharacterMinimalInformations host)
        {
            this.host = host;
        }
        

public void Serialize(IDataWriter writer)
{

host.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

host = new Types.CharacterMinimalInformations();
            host.Deserialize(reader);
            

}


}


}