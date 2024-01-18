


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class EntitiesInformationMessage : NetworkMessage
{

public const uint Id = 397;
public uint MessageId
{
    get { return Id; }
}

public Types.EntityInformation[] entities;
        

public EntitiesInformationMessage()
{
}

public EntitiesInformationMessage(Types.EntityInformation[] entities)
        {
            this.entities = entities;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)entities.Length);
            foreach (var entry in entities)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            entities = new Types.EntityInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 entities[i] = new Types.EntityInformation();
                 entities[i].Deserialize(reader);
            }
            

}


}


}