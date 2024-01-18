


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeBidPriceForSellerMessage : ExchangeBidPriceMessage
{

public const uint Id = 9690;
public uint MessageId
{
    get { return Id; }
}

public bool allIdentical;
        public double[] minimalPrices;
        

public ExchangeBidPriceForSellerMessage()
{
}

public ExchangeBidPriceForSellerMessage(uint genericId, double averagePrice, bool allIdentical, double[] minimalPrices)
         : base(genericId, averagePrice)
        {
            this.allIdentical = allIdentical;
            this.minimalPrices = minimalPrices;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(allIdentical);
            writer.WriteShort((short)minimalPrices.Length);
            foreach (var entry in minimalPrices)
            {
                 writer.WriteVarLong(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            allIdentical = reader.ReadBoolean();
            var limit = (ushort)reader.ReadUShort();
            minimalPrices = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 minimalPrices[i] = reader.ReadVarUhLong();
            }
            

}


}


}