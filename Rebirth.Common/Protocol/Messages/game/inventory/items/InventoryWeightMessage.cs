


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class InventoryWeightMessage : NetworkMessage
{

public const uint Id = 5080;
public uint MessageId
{
    get { return Id; }
}

public uint inventoryWeight;
        public uint shopWeight;
        public uint weightMax;
        

public InventoryWeightMessage()
{
}

public InventoryWeightMessage(uint inventoryWeight, uint shopWeight, uint weightMax)
        {
            this.inventoryWeight = inventoryWeight;
            this.shopWeight = shopWeight;
            this.weightMax = weightMax;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)inventoryWeight);
            writer.WriteVarInt((int)shopWeight);
            writer.WriteVarInt((int)weightMax);
            

}

public void Deserialize(IDataReader reader)
{

inventoryWeight = reader.ReadVarUhInt();
            shopWeight = reader.ReadVarUhInt();
            weightMax = reader.ReadVarUhInt();
            

}


}


}