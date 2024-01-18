


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HouseBuyResultMessage : NetworkMessage
{

public const uint Id = 3504;
public uint MessageId
{
    get { return Id; }
}

public bool secondHand;
        public bool bought;
        public uint houseId;
        public int instanceId;
        public double realPrice;
        

public HouseBuyResultMessage()
{
}

public HouseBuyResultMessage(bool secondHand, bool bought, uint houseId, int instanceId, double realPrice)
        {
            this.secondHand = secondHand;
            this.bought = bought;
            this.houseId = houseId;
            this.instanceId = instanceId;
            this.realPrice = realPrice;
        }
        

public void Serialize(IDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, secondHand);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, bought);
            writer.WriteByte(flag1);
            writer.WriteVarInt((int)houseId);
            writer.WriteInt(instanceId);
            writer.WriteVarLong(realPrice);
            

}

public void Deserialize(IDataReader reader)
{

byte flag1 = reader.ReadByte();
            secondHand = BooleanByteWrapper.GetFlag(flag1, 0);
            bought = BooleanByteWrapper.GetFlag(flag1, 1);
            houseId = reader.ReadVarUhInt();
            instanceId = reader.ReadInt();
            realPrice = reader.ReadVarUhLong();
            

}


}


}