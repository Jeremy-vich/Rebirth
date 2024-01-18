


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PaddockBuyResultMessage : NetworkMessage
{

public const uint Id = 7045;
public uint MessageId
{
    get { return Id; }
}

public double paddockId;
        public bool bought;
        public double realPrice;
        

public PaddockBuyResultMessage()
{
}

public PaddockBuyResultMessage(double paddockId, bool bought, double realPrice)
        {
            this.paddockId = paddockId;
            this.bought = bought;
            this.realPrice = realPrice;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(paddockId);
            writer.WriteBoolean(bought);
            writer.WriteVarLong(realPrice);
            

}

public void Deserialize(IDataReader reader)
{

paddockId = reader.ReadDouble();
            bought = reader.ReadBoolean();
            realPrice = reader.ReadVarUhLong();
            

}


}


}