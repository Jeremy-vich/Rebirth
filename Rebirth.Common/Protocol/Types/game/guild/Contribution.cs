


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class Contribution
{

public const short Id = 5831;
public virtual short TypeId
{
    get { return Id; }
}

public double contributorId;
        public string contributorName;
        public double amount;
        

public Contribution()
{
}

public Contribution(double contributorId, string contributorName, double amount)
        {
            this.contributorId = contributorId;
            this.contributorName = contributorName;
            this.amount = amount;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarLong(contributorId);
            writer.WriteUTF(contributorName);
            writer.WriteVarLong(amount);
            

}

public virtual void Deserialize(IDataReader reader)
{

contributorId = reader.ReadVarUhLong();
            contributorName = reader.ReadUTF();
            amount = reader.ReadVarUhLong();
            

}


}


}