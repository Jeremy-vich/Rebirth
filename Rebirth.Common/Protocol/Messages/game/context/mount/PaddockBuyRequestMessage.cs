


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PaddockBuyRequestMessage : NetworkMessage
{

public const uint Id = 960;
public uint MessageId
{
    get { return Id; }
}

public double proposedPrice;
        

public PaddockBuyRequestMessage()
{
}

public PaddockBuyRequestMessage(double proposedPrice)
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