


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AbstractPartyMessage : NetworkMessage
{

public const uint Id = 1856;
public uint MessageId
{
    get { return Id; }
}

public uint partyId;
        

public AbstractPartyMessage()
{
}

public AbstractPartyMessage(uint partyId)
        {
            this.partyId = partyId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)partyId);
            

}

public void Deserialize(IDataReader reader)
{

partyId = reader.ReadVarUhInt();
            

}


}


}