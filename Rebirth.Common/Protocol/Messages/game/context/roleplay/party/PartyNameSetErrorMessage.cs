


















// Generated on 01/30/2023 13:09:18
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PartyNameSetErrorMessage : AbstractPartyMessage
{

public const uint Id = 6589;
public uint MessageId
{
    get { return Id; }
}

public sbyte result;
        

public PartyNameSetErrorMessage()
{
}

public PartyNameSetErrorMessage(uint partyId, sbyte result)
         : base(partyId)
        {
            this.result = result;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(result);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            result = reader.ReadSbyte();
            

}


}


}