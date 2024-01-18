


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PresetDeleteResultMessage : NetworkMessage
{

public const uint Id = 718;
public uint MessageId
{
    get { return Id; }
}

public short presetId;
        public sbyte code;
        

public PresetDeleteResultMessage()
{
}

public PresetDeleteResultMessage(short presetId, sbyte code)
        {
            this.presetId = presetId;
            this.code = code;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(presetId);
            writer.WriteSbyte(code);
            

}

public void Deserialize(IDataReader reader)
{

presetId = reader.ReadShort();
            code = reader.ReadSbyte();
            

}


}


}