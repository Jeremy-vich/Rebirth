


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ShortcutObjectIdolsPreset : ShortcutObject
{

public const short Id = 9778;
public override short TypeId
{
    get { return Id; }
}

public short presetId;
        

public ShortcutObjectIdolsPreset()
{
}

public ShortcutObjectIdolsPreset(sbyte slot, short presetId)
         : base(slot)
        {
            this.presetId = presetId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(presetId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            presetId = reader.ReadShort();
            

}


}


}