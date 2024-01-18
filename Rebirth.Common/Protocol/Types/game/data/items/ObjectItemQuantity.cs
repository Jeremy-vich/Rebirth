


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ObjectItemQuantity : Item
{

public const short Id = 8102;
public override short TypeId
{
    get { return Id; }
}

public uint objectUID;
        public uint quantity;
        

public ObjectItemQuantity()
{
}

public ObjectItemQuantity(uint objectUID, uint quantity)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)objectUID);
            writer.WriteVarInt((int)quantity);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            objectUID = reader.ReadVarUhInt();
            quantity = reader.ReadVarUhInt();
            

}


}


}