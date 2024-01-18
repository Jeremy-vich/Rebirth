


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BreachInvitationOfferMessage : NetworkMessage
{

public const uint Id = 7487;
public uint MessageId
{
    get { return Id; }
}

public Types.CharacterMinimalInformations host;
        public uint timeLeftBeforeCancel;
        

public BreachInvitationOfferMessage()
{
}

public BreachInvitationOfferMessage(Types.CharacterMinimalInformations host, uint timeLeftBeforeCancel)
        {
            this.host = host;
            this.timeLeftBeforeCancel = timeLeftBeforeCancel;
        }
        

public void Serialize(IDataWriter writer)
{

host.Serialize(writer);
            writer.WriteVarInt((int)timeLeftBeforeCancel);
            

}

public void Deserialize(IDataReader reader)
{

host = new Types.CharacterMinimalInformations();
            host.Deserialize(reader);
            timeLeftBeforeCancel = reader.ReadVarUhInt();
            

}


}


}