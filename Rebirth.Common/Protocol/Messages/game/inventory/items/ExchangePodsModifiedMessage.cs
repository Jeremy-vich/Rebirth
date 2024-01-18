


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangePodsModifiedMessage : ExchangeObjectMessage
{

public const uint Id = 3685;
public uint MessageId
{
    get { return Id; }
}

public uint currentWeight;
        public uint maxWeight;
        

public ExchangePodsModifiedMessage()
{
}

public ExchangePodsModifiedMessage(bool remote, uint currentWeight, uint maxWeight)
         : base(remote)
        {
            this.currentWeight = currentWeight;
            this.maxWeight = maxWeight;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)currentWeight);
            writer.WriteVarInt((int)maxWeight);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            currentWeight = reader.ReadVarUhInt();
            maxWeight = reader.ReadVarUhInt();
            

}


}


}