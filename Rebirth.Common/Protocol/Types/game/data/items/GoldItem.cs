


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GoldItem : Item
{

public const short Id = 7613;
public override short TypeId
{
    get { return Id; }
}

public double sum;
        

public GoldItem()
{
}

public GoldItem(double sum)
        {
            this.sum = sum;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(sum);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            sum = reader.ReadVarUhLong();
            

}


}


}