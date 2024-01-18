


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PresetsMessage : NetworkMessage
{

public const uint Id = 7904;
public uint MessageId
{
    get { return Id; }
}

public Types.Preset[] presets;
        

public PresetsMessage()
{
}

public PresetsMessage(Types.Preset[] presets)
        {
            this.presets = presets;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)presets.Length);
            foreach (var entry in presets)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            presets = new Types.Preset[limit];
            for (int i = 0; i < limit; i++)
            {
                 presets[i] = ProtocolTypeManager.GetInstance<Types.Preset>(reader.ReadUShort());
                 presets[i].Deserialize(reader);
            }
            

}


}


}