


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class InviteInHavenBagClosedMessage : NetworkMessage
{

public const uint Id = 8380;
public uint MessageId
{
    get { return Id; }
}

public Types.CharacterMinimalInformations hostInformations;
        

public InviteInHavenBagClosedMessage()
{
}

public InviteInHavenBagClosedMessage(Types.CharacterMinimalInformations hostInformations)
        {
            this.hostInformations = hostInformations;
        }
        

public void Serialize(IDataWriter writer)
{

hostInformations.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

hostInformations = new Types.CharacterMinimalInformations();
            hostInformations.Deserialize(reader);
            

}


}


}