


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeBuyMessage : NetworkMessage
{

public const uint Id = 3840;
public uint MessageId
{
    get { return Id; }
}

public uint objectToBuyId;
        public uint quantity;
        

public ExchangeBuyMessage()
{
}

public ExchangeBuyMessage(uint objectToBuyId, uint quantity)
        {
            this.objectToBuyId = objectToBuyId;
            this.quantity = quantity;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectToBuyId);
            writer.WriteVarInt((int)quantity);
            

}

public void Deserialize(IDataReader reader)
{

objectToBuyId = reader.ReadVarUhInt();
            quantity = reader.ReadVarUhInt();
            

}


}


}