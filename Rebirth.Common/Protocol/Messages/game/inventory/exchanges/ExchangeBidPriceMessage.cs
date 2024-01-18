


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeBidPriceMessage : NetworkMessage
{

public const uint Id = 1265;
public uint MessageId
{
    get { return Id; }
}

public uint genericId;
        public double averagePrice;
        

public ExchangeBidPriceMessage()
{
}

public ExchangeBidPriceMessage(uint genericId, double averagePrice)
        {
            this.genericId = genericId;
            this.averagePrice = averagePrice;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)genericId);
            writer.WriteVarLong(averagePrice);
            

}

public void Deserialize(IDataReader reader)
{

genericId = reader.ReadVarUhInt();
            averagePrice = reader.ReadVarLong();
            

}


}


}