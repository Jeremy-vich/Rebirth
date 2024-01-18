


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class InvalidPresetsMessage : NetworkMessage
{

public const uint Id = 9117;
public uint MessageId
{
    get { return Id; }
}

public short[] presetIds;
        

public InvalidPresetsMessage()
{
}

public InvalidPresetsMessage(short[] presetIds)
        {
            this.presetIds = presetIds;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)presetIds.Length);
            foreach (var entry in presetIds)
            {
                 writer.WriteShort(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            presetIds = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 presetIds[i] = reader.ReadShort();
            }
            

}


}


}