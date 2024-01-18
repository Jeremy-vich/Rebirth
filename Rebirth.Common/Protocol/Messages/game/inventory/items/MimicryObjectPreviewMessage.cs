


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MimicryObjectPreviewMessage : NetworkMessage
{

public const uint Id = 816;
public uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem result;
        

public MimicryObjectPreviewMessage()
{
}

public MimicryObjectPreviewMessage(Types.ObjectItem result)
        {
            this.result = result;
        }
        

public void Serialize(IDataWriter writer)
{

result.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

result = new Types.ObjectItem();
            result.Deserialize(reader);
            

}


}


}