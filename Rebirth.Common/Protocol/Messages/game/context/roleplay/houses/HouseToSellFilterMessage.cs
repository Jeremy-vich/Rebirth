


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HouseToSellFilterMessage : NetworkMessage
{

public const uint Id = 6849;
public uint MessageId
{
    get { return Id; }
}

public int areaId;
        public sbyte atLeastNbRoom;
        public sbyte atLeastNbChest;
        public uint skillRequested;
        public double maxPrice;
        public sbyte orderBy;
        

public HouseToSellFilterMessage()
{
}

public HouseToSellFilterMessage(int areaId, sbyte atLeastNbRoom, sbyte atLeastNbChest, uint skillRequested, double maxPrice, sbyte orderBy)
        {
            this.areaId = areaId;
            this.atLeastNbRoom = atLeastNbRoom;
            this.atLeastNbChest = atLeastNbChest;
            this.skillRequested = skillRequested;
            this.maxPrice = maxPrice;
            this.orderBy = orderBy;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(areaId);
            writer.WriteSbyte(atLeastNbRoom);
            writer.WriteSbyte(atLeastNbChest);
            writer.WriteVarShort((int)skillRequested);
            writer.WriteVarLong(maxPrice);
            writer.WriteSbyte(orderBy);
            

}

public void Deserialize(IDataReader reader)
{

areaId = reader.ReadInt();
            atLeastNbRoom = reader.ReadSbyte();
            atLeastNbChest = reader.ReadSbyte();
            skillRequested = reader.ReadVarUhShort();
            maxPrice = reader.ReadVarUhLong();
            orderBy = reader.ReadSbyte();
            

}


}


}