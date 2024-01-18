


















// Generated on 01/30/2023 13:09:18
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PartyKickedByMessage : AbstractPartyMessage
{

public const uint Id = 3337;
public uint MessageId
{
    get { return Id; }
}

public double kickerId;
        

public PartyKickedByMessage()
{
}

public PartyKickedByMessage(uint partyId, double kickerId)
         : base(partyId)
        {
            this.kickerId = kickerId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(kickerId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            kickerId = reader.ReadVarUhLong();
            

}


}


}