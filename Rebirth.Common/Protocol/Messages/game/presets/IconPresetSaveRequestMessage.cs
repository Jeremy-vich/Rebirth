


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class IconPresetSaveRequestMessage : NetworkMessage
{

public const uint Id = 717;
public uint MessageId
{
    get { return Id; }
}

public short presetId;
        public sbyte symbolId;
        public bool updateData;
        

public IconPresetSaveRequestMessage()
{
}

public IconPresetSaveRequestMessage(short presetId, sbyte symbolId, bool updateData)
        {
            this.presetId = presetId;
            this.symbolId = symbolId;
            this.updateData = updateData;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(presetId);
            writer.WriteSbyte(symbolId);
            writer.WriteBoolean(updateData);
            

}

public void Deserialize(IDataReader reader)
{

presetId = reader.ReadShort();
            symbolId = reader.ReadSbyte();
            updateData = reader.ReadBoolean();
            

}


}


}