


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class PaddockBuyableInformations
{

public const short Id = 1961;
public virtual short TypeId
{
    get { return Id; }
}

public double price;
        public bool locked;
        

public PaddockBuyableInformations()
{
}

public PaddockBuyableInformations(double price, bool locked)
        {
            this.price = price;
            this.locked = locked;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarLong(price);
            writer.WriteBoolean(locked);
            

}

public virtual void Deserialize(IDataReader reader)
{

price = reader.ReadVarUhLong();
            locked = reader.ReadBoolean();
            

}


}


}