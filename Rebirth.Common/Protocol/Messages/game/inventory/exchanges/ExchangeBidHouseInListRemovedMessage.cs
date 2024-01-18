


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeBidHouseInListRemovedMessage : NetworkMessage
{

public const uint Id = 531;
public uint MessageId
{
    get { return Id; }
}

public int itemUID;
        public uint objectGID;
        public int objectType;
        

public ExchangeBidHouseInListRemovedMessage()
{
}

public ExchangeBidHouseInListRemovedMessage(int itemUID, uint objectGID, int objectType)
        {
            this.itemUID = itemUID;
            this.objectGID = objectGID;
            this.objectType = objectType;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(itemUID);
            writer.WriteVarInt((int)objectGID);
            writer.WriteInt(objectType);
            

}

public void Deserialize(IDataReader reader)
{

itemUID = reader.ReadInt();
            objectGID = reader.ReadVarUhInt();
            objectType = reader.ReadInt();
            

}


}


}