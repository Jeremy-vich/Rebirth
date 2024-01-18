


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PaddockSellBuyDialogMessage : NetworkMessage
{

public const uint Id = 6699;
public uint MessageId
{
    get { return Id; }
}

public bool bsell;
        public uint ownerId;
        public double price;
        

public PaddockSellBuyDialogMessage()
{
}

public PaddockSellBuyDialogMessage(bool bsell, uint ownerId, double price)
        {
            this.bsell = bsell;
            this.ownerId = ownerId;
            this.price = price;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(bsell);
            writer.WriteVarInt((int)ownerId);
            writer.WriteVarLong(price);
            

}

public void Deserialize(IDataReader reader)
{

bsell = reader.ReadBoolean();
            ownerId = reader.ReadVarUhInt();
            price = reader.ReadVarUhLong();
            

}


}


}