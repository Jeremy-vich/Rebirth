


















// Generated on 01/30/2023 13:09:25
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeShopStockMovementRemovedMessage : NetworkMessage
{

public const uint Id = 882;
public uint MessageId
{
    get { return Id; }
}

public uint objectId;
        

public ExchangeShopStockMovementRemovedMessage()
{
}

public ExchangeShopStockMovementRemovedMessage(uint objectId)
        {
            this.objectId = objectId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectId);
            

}

public void Deserialize(IDataReader reader)
{

objectId = reader.ReadVarUhInt();
            

}


}


}