


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeTypesItemsExchangerDescriptionForUserMessage : NetworkMessage
{

public const uint Id = 6062;
public uint MessageId
{
    get { return Id; }
}

public uint objectGID;
        public int objectType;
        public Types.BidExchangerObjectInfo[] itemTypeDescriptions;
        

public ExchangeTypesItemsExchangerDescriptionForUserMessage()
{
}

public ExchangeTypesItemsExchangerDescriptionForUserMessage(uint objectGID, int objectType, Types.BidExchangerObjectInfo[] itemTypeDescriptions)
        {
            this.objectGID = objectGID;
            this.objectType = objectType;
            this.itemTypeDescriptions = itemTypeDescriptions;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectGID);
            writer.WriteInt(objectType);
            writer.WriteShort((short)itemTypeDescriptions.Length);
            foreach (var entry in itemTypeDescriptions)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

objectGID = reader.ReadVarUhInt();
            objectType = reader.ReadInt();
            var limit = (ushort)reader.ReadUShort();
            itemTypeDescriptions = new Types.BidExchangerObjectInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 itemTypeDescriptions[i] = new Types.BidExchangerObjectInfo();
                 itemTypeDescriptions[i].Deserialize(reader);
            }
            

}


}


}