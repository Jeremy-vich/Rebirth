


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AbstractPartyEventMessage : AbstractPartyMessage
{

public const uint Id = 4448;
public uint MessageId
{
    get { return Id; }
}



public AbstractPartyEventMessage()
{
}

public AbstractPartyEventMessage(uint partyId)
         : base(partyId)
        {
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}