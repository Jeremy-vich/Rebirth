


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectQuantityMessage : NetworkMessage
{

public const uint Id = 5311;
public uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        public uint quantity;
        public sbyte origin;
        

public ObjectQuantityMessage()
{
}

public ObjectQuantityMessage(uint objectUID, uint quantity, sbyte origin)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
            this.origin = origin;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectUID);
            writer.WriteVarInt((int)quantity);
            writer.WriteSbyte(origin);
            

}

public void Deserialize(IDataReader reader)
{

objectUID = reader.ReadVarUhInt();
            quantity = reader.ReadVarUhInt();
            origin = reader.ReadSbyte();
            

}


}


}