


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AccountSubscriptionElapsedDurationMessage : NetworkMessage
{

public const uint Id = 3364;
public uint MessageId
{
    get { return Id; }
}

public double subscriptionElapsedDuration;
        

public AccountSubscriptionElapsedDurationMessage()
{
}

public AccountSubscriptionElapsedDurationMessage(double subscriptionElapsedDuration)
        {
            this.subscriptionElapsedDuration = subscriptionElapsedDuration;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(subscriptionElapsedDuration);
            

}

public void Deserialize(IDataReader reader)
{

subscriptionElapsedDuration = reader.ReadDouble();
            

}


}


}