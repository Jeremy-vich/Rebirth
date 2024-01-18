


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class JobAllowMultiCraftRequestMessage : NetworkMessage
{

public const uint Id = 3912;
public uint MessageId
{
    get { return Id; }
}

public bool enabled;
        

public JobAllowMultiCraftRequestMessage()
{
}

public JobAllowMultiCraftRequestMessage(bool enabled)
        {
            this.enabled = enabled;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(enabled);
            

}

public void Deserialize(IDataReader reader)
{

enabled = reader.ReadBoolean();
            

}


}


}