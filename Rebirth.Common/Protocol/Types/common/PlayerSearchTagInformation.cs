


















// Generated on 01/30/2023 13:09:30
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class PlayerSearchTagInformation : AbstractPlayerSearchInformation
{

public const short Id = 8414;
public override short TypeId
{
    get { return Id; }
}

public Types.AccountTagInformation tag;
        

public PlayerSearchTagInformation()
{
}

public PlayerSearchTagInformation(Types.AccountTagInformation tag)
        {
            this.tag = tag;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            tag.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            tag = new Types.AccountTagInformation();
            tag.Deserialize(reader);
            

}


}


}