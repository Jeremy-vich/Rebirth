


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ChatClientPrivateWithObjectMessage : ChatClientPrivateMessage
{

public const uint Id = 2701;
public uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem[] objects;
        

public ChatClientPrivateWithObjectMessage()
{
}

public ChatClientPrivateWithObjectMessage(string content, Types.AbstractPlayerSearchInformation receiver, Types.ObjectItem[] objects)
         : base(content, receiver)
        {
            this.objects = objects;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)objects.Length);
            foreach (var entry in objects)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            objects = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 objects[i] = new Types.ObjectItem();
                 objects[i].Deserialize(reader);
            }
            

}


}


}