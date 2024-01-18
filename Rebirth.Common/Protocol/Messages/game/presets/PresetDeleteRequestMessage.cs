


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PresetDeleteRequestMessage : NetworkMessage
{

public const uint Id = 2584;
public uint MessageId
{
    get { return Id; }
}

public short presetId;
        

public PresetDeleteRequestMessage()
{
}

public PresetDeleteRequestMessage(short presetId)
        {
            this.presetId = presetId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(presetId);
            

}

public void Deserialize(IDataReader reader)
{

presetId = reader.ReadShort();
            

}


}


}