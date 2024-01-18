


















// Generated on 01/30/2023 13:09:25
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeSellMessage : NetworkMessage
{

public const uint Id = 2826;
public uint MessageId
{
    get { return Id; }
}

public uint objectToSellId;
        public uint quantity;
        

public ExchangeSellMessage()
{
}

public ExchangeSellMessage(uint objectToSellId, uint quantity)
        {
            this.objectToSellId = objectToSellId;
            this.quantity = quantity;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectToSellId);
            writer.WriteVarInt((int)quantity);
            

}

public void Deserialize(IDataReader reader)
{

objectToSellId = reader.ReadVarUhInt();
            quantity = reader.ReadVarUhInt();
            

}


}


}