


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectsQuantityMessage : NetworkMessage
{

public const uint Id = 6742;
public uint MessageId
{
    get { return Id; }
}

public Types.ObjectItemQuantity[] objectsUIDAndQty;
        

public ObjectsQuantityMessage()
{
}

public ObjectsQuantityMessage(Types.ObjectItemQuantity[] objectsUIDAndQty)
        {
            this.objectsUIDAndQty = objectsUIDAndQty;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)objectsUIDAndQty.Length);
            foreach (var entry in objectsUIDAndQty)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            objectsUIDAndQty = new Types.ObjectItemQuantity[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectsUIDAndQty[i] = new Types.ObjectItemQuantity();
                 objectsUIDAndQty[i].Deserialize(reader);
            }
            

}


}


}