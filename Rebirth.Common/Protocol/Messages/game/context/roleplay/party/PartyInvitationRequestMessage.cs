


















// Generated on 01/30/2023 13:09:18
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PartyInvitationRequestMessage : NetworkMessage
{

public const uint Id = 4199;
public uint MessageId
{
    get { return Id; }
}

public Types.AbstractPlayerSearchInformation target;
        

public PartyInvitationRequestMessage()
{
}

public PartyInvitationRequestMessage(Types.AbstractPlayerSearchInformation target)
        {
            this.target = target;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(target.TypeId);
            target.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

target = ProtocolTypeManager.GetInstance<Types.AbstractPlayerSearchInformation>(reader.ReadUShort());
            target.Deserialize(reader);
            

}


}


}