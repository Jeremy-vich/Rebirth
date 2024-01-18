


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectAveragePricesMessage : NetworkMessage
{

public const uint Id = 4462;
public uint MessageId
{
    get { return Id; }
}

public uint[] ids;
        public double[] avgPrices;
        

public ObjectAveragePricesMessage()
{
}

public ObjectAveragePricesMessage(uint[] ids, double[] avgPrices)
        {
            this.ids = ids;
            this.avgPrices = avgPrices;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)ids.Length);
            foreach (var entry in ids)
            {
                 writer.WriteVarInt((int)entry);
            }
            writer.WriteShort((short)avgPrices.Length);
            foreach (var entry in avgPrices)
            {
                 writer.WriteVarLong(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            ids = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 ids[i] = reader.ReadVarUhInt();
            }
            limit = (ushort)reader.ReadUShort();
            avgPrices = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 avgPrices[i] = reader.ReadVarUhLong();
            }
            

}


}


}