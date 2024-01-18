


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectModifiedMessage : NetworkMessage
{

public const uint Id = 5140;
public uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem @object;
        

public ObjectModifiedMessage()
{
}

public ObjectModifiedMessage(Types.ObjectItem @object)
        {
            this.@object = @object;
        }
        

public void Serialize(IDataWriter writer)
{

@object.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

@object = new Types.ObjectItem();
            @object.Deserialize(reader);
            

}


}


}