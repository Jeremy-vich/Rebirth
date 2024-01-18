


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PaddockToSellFilterMessage : NetworkMessage
{

public const uint Id = 1863;
public uint MessageId
{
    get { return Id; }
}

public int areaId;
        public sbyte atLeastNbMount;
        public sbyte atLeastNbMachine;
        public double maxPrice;
        public sbyte orderBy;
        

public PaddockToSellFilterMessage()
{
}

public PaddockToSellFilterMessage(int areaId, sbyte atLeastNbMount, sbyte atLeastNbMachine, double maxPrice, sbyte orderBy)
        {
            this.areaId = areaId;
            this.atLeastNbMount = atLeastNbMount;
            this.atLeastNbMachine = atLeastNbMachine;
            this.maxPrice = maxPrice;
            this.orderBy = orderBy;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(areaId);
            writer.WriteSbyte(atLeastNbMount);
            writer.WriteSbyte(atLeastNbMachine);
            writer.WriteVarLong(maxPrice);
            writer.WriteSbyte(orderBy);
            

}

public void Deserialize(IDataReader reader)
{

areaId = reader.ReadInt();
            atLeastNbMount = reader.ReadSbyte();
            atLeastNbMachine = reader.ReadSbyte();
            maxPrice = reader.ReadVarUhLong();
            orderBy = reader.ReadSbyte();
            

}


}


}