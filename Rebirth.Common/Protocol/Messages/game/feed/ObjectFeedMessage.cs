


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectFeedMessage : NetworkMessage
{

public const uint Id = 7649;
public uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        public Types.ObjectItemQuantity[] meal;
        

public ObjectFeedMessage()
{
}

public ObjectFeedMessage(uint objectUID, Types.ObjectItemQuantity[] meal)
        {
            this.objectUID = objectUID;
            this.meal = meal;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectUID);
            writer.WriteShort((short)meal.Length);
            foreach (var entry in meal)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

objectUID = reader.ReadVarUhInt();
            var limit = (ushort)reader.ReadUShort();
            meal = new Types.ObjectItemQuantity[limit];
            for (int i = 0; i < limit; i++)
            {
                 meal[i] = new Types.ObjectItemQuantity();
                 meal[i].Deserialize(reader);
            }
            

}


}


}