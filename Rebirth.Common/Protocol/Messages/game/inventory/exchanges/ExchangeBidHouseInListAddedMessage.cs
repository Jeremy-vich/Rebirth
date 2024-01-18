


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeBidHouseInListAddedMessage : NetworkMessage
{

public const uint Id = 4304;
public uint MessageId
{
    get { return Id; }
}

public int itemUID;
        public uint objectGID;
        public int objectType;
        public Types.ObjectEffect[] effects;
        public double[] prices;
        

public ExchangeBidHouseInListAddedMessage()
{
}

public ExchangeBidHouseInListAddedMessage(int itemUID, uint objectGID, int objectType, Types.ObjectEffect[] effects, double[] prices)
        {
            this.itemUID = itemUID;
            this.objectGID = objectGID;
            this.objectType = objectType;
            this.effects = effects;
            this.prices = prices;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(itemUID);
            writer.WriteVarInt((int)objectGID);
            writer.WriteInt(objectType);
            writer.WriteShort((short)effects.Length);
            foreach (var entry in effects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)prices.Length);
            foreach (var entry in prices)
            {
                 writer.WriteVarLong(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

itemUID = reader.ReadInt();
            objectGID = reader.ReadVarUhInt();
            objectType = reader.ReadInt();
            var limit = (ushort)reader.ReadUShort();
            effects = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 effects[i] = ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadUShort());
                 effects[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            prices = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 prices[i] = reader.ReadVarUhLong();
            }
            

}


}


}