


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class DebtInformation
{

public const short Id = 2854;
public virtual short TypeId
{
    get { return Id; }
}

public double id;
        public double timestamp;
        

public DebtInformation()
{
}

public DebtInformation(double id, double timestamp)
        {
            this.id = id;
            this.timestamp = timestamp;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteDouble(id);
            writer.WriteDouble(timestamp);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadDouble();
            timestamp = reader.ReadDouble();
            

}


}


}