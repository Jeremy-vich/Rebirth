


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectsAddedMessage : NetworkMessage
{

public const uint Id = 2889;
public uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem[] @object;
        

public ObjectsAddedMessage()
{
}

public ObjectsAddedMessage(Types.ObjectItem[] @object)
        {
            this.@object = @object;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)@object.Length);
            foreach (var entry in @object)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            @object = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 @object[i] = new Types.ObjectItem();
                 @object[i].Deserialize(reader);
            }
            

}


}


}