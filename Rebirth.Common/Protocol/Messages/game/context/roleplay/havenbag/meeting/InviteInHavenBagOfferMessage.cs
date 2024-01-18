


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class InviteInHavenBagOfferMessage : NetworkMessage
{

public const uint Id = 3354;
public uint MessageId
{
    get { return Id; }
}

public Types.CharacterMinimalInformations hostInformations;
        public int timeLeftBeforeCancel;
        

public InviteInHavenBagOfferMessage()
{
}

public InviteInHavenBagOfferMessage(Types.CharacterMinimalInformations hostInformations, int timeLeftBeforeCancel)
        {
            this.hostInformations = hostInformations;
            this.timeLeftBeforeCancel = timeLeftBeforeCancel;
        }
        

public void Serialize(IDataWriter writer)
{

hostInformations.Serialize(writer);
            writer.WriteVarInt((int)timeLeftBeforeCancel);
            

}

public void Deserialize(IDataReader reader)
{

hostInformations = new Types.CharacterMinimalInformations();
            hostInformations.Deserialize(reader);
            timeLeftBeforeCancel = reader.ReadVarInt();
            

}


}


}