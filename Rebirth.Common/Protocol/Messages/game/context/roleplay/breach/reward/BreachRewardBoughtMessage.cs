


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BreachRewardBoughtMessage : NetworkMessage
{

public const uint Id = 3796;
public uint MessageId
{
    get { return Id; }
}

public uint id;
        public bool bought;
        

public BreachRewardBoughtMessage()
{
}

public BreachRewardBoughtMessage(uint id, bool bought)
        {
            this.id = id;
            this.bought = bought;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)id);
            writer.WriteBoolean(bought);
            

}

public void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhInt();
            bought = reader.ReadBoolean();
            

}


}


}