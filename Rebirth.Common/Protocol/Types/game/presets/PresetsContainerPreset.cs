


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Types
{

public class PresetsContainerPreset : Preset
{

public const short Id = 5978;
public override short TypeId
{
    get { return Id; }
}

public Types.Preset[] presets;
        

public PresetsContainerPreset()
{
}

public PresetsContainerPreset(short id, Types.Preset[] presets)
         : base(id)
        {
            this.presets = presets;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)presets.Length);
            foreach (var entry in presets)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
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