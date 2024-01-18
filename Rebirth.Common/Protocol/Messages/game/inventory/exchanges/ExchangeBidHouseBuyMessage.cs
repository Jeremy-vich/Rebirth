


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeBidHouseBuyMessage : NetworkMessage
{

public const uint Id = 5543;
public uint MessageId
{
    get { return Id; }
}

public uint uid;
        public uint qty;
        public double price;
        

public ExchangeBidHouseBuyMessage()
{
}

public ExchangeBidHouseBuyMessage(uint uid, uint qty, double price)
        {
            this.uid = uid;
            this.qty = qty;
            this.price = price;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)uid);
            writer.WriteVarInt((int)qty);
            writer.WriteVarLong(price);
            

}

public void Deserialize(IDataReader reader)
{

uid = reader.ReadVarUhInt();
            qty = reader.ReadVarUhInt();
            price = reader.ReadVarUhLong();
            

}


}


}