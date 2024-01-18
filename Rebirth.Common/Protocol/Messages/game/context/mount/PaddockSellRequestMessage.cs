


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PaddockSellRequestMessage : NetworkMessage
{

public const uint Id = 1652;
public uint MessageId
{
    get { return Id; }
}

public double price;
        public bool forSale;
        

public PaddockSellRequestMessage()
{
}

public PaddockSellRequestMessage(double price, bool forSale)
        {
            this.price = price;
            this.forSale = forSale;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(price);
            writer.WriteBoolean(forSale);
            

}

public void Deserialize(IDataReader reader)
{

price = reader.ReadVarUhLong();
            forSale = reader.ReadBoolean();
            

}


}


}