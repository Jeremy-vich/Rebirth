


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectSetPositionMessage : NetworkMessage
{

public const uint Id = 4064;
public uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        public short position;
        public uint quantity;
        

public ObjectSetPositionMessage()
{
}

public ObjectSetPositionMessage(uint objectUID, short position, uint quantity)
        {
            this.objectUID = objectUID;
            this.position = position;
            this.quantity = quantity;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectUID);
            writer.WriteShort(position);
            writer.WriteVarInt((int)quantity);
            

}

public void Deserialize(IDataReader reader)
{

objectUID = reader.ReadVarUhInt();
            position = reader.ReadShort();
            quantity = reader.ReadVarUhInt();
            

}


}


}