


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class KamaDebtInformation : DebtInformation
{

public const short Id = 1295;
public override short TypeId
{
    get { return Id; }
}

public double kamas;
        

public KamaDebtInformation()
{
}

public KamaDebtInformation(double id, double timestamp, double kamas)
         : base(id, timestamp)
        {
            this.kamas = kamas;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(kamas);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            kamas = reader.ReadVarUhLong();
            

}


}


}