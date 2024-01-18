


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BreachRewardsMessage : NetworkMessage
{

public const uint Id = 2148;
public uint MessageId
{
    get { return Id; }
}

public Types.BreachReward[] rewards;
        

public BreachRewardsMessage()
{
}

public BreachRewardsMessage(Types.BreachReward[] rewards)
        {
            this.rewards = rewards;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)rewards.Length);
            foreach (var entry in rewards)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            rewards = new Types.BreachReward[limit];
            for (int i = 0; i < limit; i++)
            {
                 rewards[i] = new Types.BreachReward();
                 rewards[i].Deserialize(reader);
            }
            

}


}


}