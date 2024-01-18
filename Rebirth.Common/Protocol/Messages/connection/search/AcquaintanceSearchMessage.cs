


















// Generated on 01/30/2023 13:09:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AcquaintanceSearchMessage : NetworkMessage
{

public const uint Id = 1737;
public uint MessageId
{
    get { return Id; }
}

public Types.AccountTagInformation tag;
        

public AcquaintanceSearchMessage()
{
}

public AcquaintanceSearchMessage(Types.AccountTagInformation tag)
        {
            this.tag = tag;
        }
        

public void Serialize(IDataWriter writer)
{

tag.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

tag = new Types.AccountTagInformation();
            tag.Deserialize(reader);
            

}


}


}