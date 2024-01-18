


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class IconNamedPreset : PresetsContainerPreset
{

public const short Id = 5740;
public override short TypeId
{
    get { return Id; }
}

public short iconId;
        public string name;
        

public IconNamedPreset()
{
}

public IconNamedPreset(short id, Types.Preset[] presets, short iconId, string name)
         : base(id, presets)
        {
            this.iconId = iconId;
            this.name = name;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(iconId);
            writer.WriteUTF(name);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            iconId = reader.ReadShort();
            name = reader.ReadUTF();
            

}


}


}