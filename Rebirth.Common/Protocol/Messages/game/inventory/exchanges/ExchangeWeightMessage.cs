


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeWeightMessage : NetworkMessage
{

public const uint Id = 825;
public uint MessageId
{
    get { return Id; }
}

public uint currentWeight;
        public uint maxWeight;
        

public ExchangeWeightMessage()
{
}

public ExchangeWeightMessage(uint currentWeight, uint maxWeight)
        {
            this.currentWeight = currentWeight;
            this.maxWeight = maxWeight;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)currentWeight);
            writer.WriteVarInt((int)maxWeight);
            

}

public void Deserialize(IDataReader reader)
{

currentWeight = reader.ReadVarUhInt();
            maxWeight = reader.ReadVarUhInt();
            

}


}


}