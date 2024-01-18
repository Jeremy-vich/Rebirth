


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HouseBuyRequestMessage : NetworkMessage
{

public const uint Id = 3073;
public uint MessageId
{
    get { return Id; }
}

public double proposedPrice;
        

public HouseBuyRequestMessage()
{
}

public HouseBuyRequestMessage(double proposedPrice)
        {
            this.proposedPrice = proposedPrice;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(proposedPrice);
            

}

public void Deserialize(IDataReader reader)
{

proposedPrice = reader.ReadVarUhLong();
            

}


}


}