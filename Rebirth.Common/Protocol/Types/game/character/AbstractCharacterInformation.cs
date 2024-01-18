


















// Generated on 01/30/2023 13:09:30
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class AbstractCharacterInformation
{

public const short Id = 7441;
public virtual short TypeId
{
    get { return Id; }
}

public double id;
        

public AbstractCharacterInformation()
{
}

public AbstractCharacterInformation(double id)
        {
            this.id = id;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarLong(id);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhLong();
            

}


}


}