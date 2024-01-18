


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class SubscriptionZoneMessage : NetworkMessage
{

public const uint Id = 5411;
public uint MessageId
{
    get { return Id; }
}

public bool active;
        

public SubscriptionZoneMessage()
{
}

public SubscriptionZoneMessage(bool active)
        {
            this.active = active;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(active);
            

}

public void Deserialize(IDataReader reader)
{

active = reader.ReadBoolean();
            

}


}


}