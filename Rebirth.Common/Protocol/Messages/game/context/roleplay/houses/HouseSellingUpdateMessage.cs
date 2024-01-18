


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HouseSellingUpdateMessage : NetworkMessage
{

public const uint Id = 2570;
public uint MessageId
{
    get { return Id; }
}

public uint houseId;
        public int instanceId;
        public bool secondHand;
        public double realPrice;
        public Types.AccountTagInformation buyerTag;
        

public HouseSellingUpdateMessage()
{
}

public HouseSellingUpdateMessage(uint houseId, int instanceId, bool secondHand, double realPrice, Types.AccountTagInformation buyerTag)
        {
            this.houseId = houseId;
            this.instanceId = instanceId;
            this.secondHand = secondHand;
            this.realPrice = realPrice;
            this.buyerTag = buyerTag;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)houseId);
            writer.WriteInt(instanceId);
            writer.WriteBoolean(secondHand);
            writer.WriteVarLong(realPrice);
            buyerTag.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

houseId = reader.ReadVarUhInt();
            instanceId = reader.ReadInt();
            secondHand = reader.ReadBoolean();
            realPrice = reader.ReadVarUhLong();
            buyerTag = new Types.AccountTagInformation();
            buyerTag.Deserialize(reader);
            

}


}


}