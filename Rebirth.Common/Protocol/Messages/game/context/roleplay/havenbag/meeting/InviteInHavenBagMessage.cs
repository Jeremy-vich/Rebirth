


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class InviteInHavenBagMessage : NetworkMessage
{

public const uint Id = 4438;
public uint MessageId
{
    get { return Id; }
}

public Types.CharacterMinimalInformations guestInformations;
        public bool accept;
        

public InviteInHavenBagMessage()
{
}

public InviteInHavenBagMessage(Types.CharacterMinimalInformations guestInformations, bool accept)
        {
            this.guestInformations = guestInformations;
            this.accept = accept;
        }
        

public void Serialize(IDataWriter writer)
{

guestInformations.Serialize(writer);
            writer.WriteBoolean(accept);
            

}

public void Deserialize(IDataReader reader)
{

guestInformations = new Types.CharacterMinimalInformations();
            guestInformations.Deserialize(reader);
            accept = reader.ReadBoolean();
            

}


}


}