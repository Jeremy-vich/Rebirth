


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class IgnoredInformations : AbstractContactInformations
{

public const short Id = 3964;
public override short TypeId
{
    get { return Id; }
}



public IgnoredInformations()
{
}

public IgnoredInformations(int accountId, Types.AccountTagInformation accountTag)
         : base(accountId, accountTag)
        {
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}