


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class JobBookSubscriptionMessage : NetworkMessage
{

public const uint Id = 3574;
public uint MessageId
{
    get { return Id; }
}

public Types.JobBookSubscription[] subscriptions;
        

public JobBookSubscriptionMessage()
{
}

public JobBookSubscriptionMessage(Types.JobBookSubscription[] subscriptions)
        {
            this.subscriptions = subscriptions;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)subscriptions.Length);
            foreach (var entry in subscriptions)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            subscriptions = new Types.JobBookSubscription[limit];
            for (int i = 0; i < limit; i++)
            {
                 subscriptions[i] = new Types.JobBookSubscription();
                 subscriptions[i].Deserialize(reader);
            }
            

}


}


}