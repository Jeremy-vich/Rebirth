


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BreachInvitationResponseMessage : NetworkMessage
{

public const uint Id = 8900;
public uint MessageId
{
    get { return Id; }
}

public Types.CharacterMinimalInformations guest;
        public bool accept;
        

public BreachInvitationResponseMessage()
{
}

public BreachInvitationResponseMessage(Types.CharacterMinimalInformations guest, bool accept)
        {
            this.guest = guest;
            this.accept = accept;
        }
        

public void Serialize(IDataWriter writer)
{

guest.Serialize(writer);
            writer.WriteBoolean(accept);
            

}

public void Deserialize(IDataReader reader)
{

guest = new Types.CharacterMinimalInformations();
            guest.Deserialize(reader);
            accept = reader.ReadBoolean();
            

}


}


}