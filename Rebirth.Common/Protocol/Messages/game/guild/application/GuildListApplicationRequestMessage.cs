


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildListApplicationRequestMessage : PaginationRequestAbstractMessage
{

public const uint Id = 4413;
public uint MessageId
{
    get { return Id; }
}



public GuildListApplicationRequestMessage()
{
}

public GuildListApplicationRequestMessage(double offset, uint count)
         : base(offset, count)
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