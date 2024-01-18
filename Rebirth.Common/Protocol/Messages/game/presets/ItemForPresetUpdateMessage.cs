


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ItemForPresetUpdateMessage : NetworkMessage
{

public const uint Id = 5361;
public uint MessageId
{
    get { return Id; }
}

public short presetId;
        public Types.ItemForPreset presetItem;
        

public ItemForPresetUpdateMessage()
{
}

public ItemForPresetUpdateMessage(short presetId, Types.ItemForPreset presetItem)
        {
            this.presetId = presetId;
            this.presetItem = presetItem;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(presetId);
            presetItem.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

presetId = reader.ReadShort();
            presetItem = new Types.ItemForPreset();
            presetItem.Deserialize(reader);
            

}


}


}