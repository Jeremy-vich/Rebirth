


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PresetSavedMessage : NetworkMessage
{

public const uint Id = 2124;
public uint MessageId
{
    get { return Id; }
}

public short presetId;
        public Types.Preset preset;
        

public PresetSavedMessage()
{
}

public PresetSavedMessage(short presetId, Types.Preset preset)
        {
            this.presetId = presetId;
            this.preset = preset;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(presetId);
            writer.WriteShort(preset.TypeId);
            preset.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

presetId = reader.ReadShort();
            preset = ProtocolTypeManager.GetInstance<Types.Preset>(reader.ReadUShort());
            preset.Deserialize(reader);
            

}


}


}