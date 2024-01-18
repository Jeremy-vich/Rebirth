


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class StorageObjectsUpdateMessage : NetworkMessage
{

public const uint Id = 8558;
public uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem[] objectList;
        

public StorageObjectsUpdateMessage()
{
}

public StorageObjectsUpdateMessage(Types.ObjectItem[] objectList)
        {
            this.objectList = objectList;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)objectList.Length);
            foreach (var entry in objectList)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            objectList = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectList[i] = new Types.ObjectItem();
                 objectList[i].Deserialize(reader);
            }
            

}


}


}