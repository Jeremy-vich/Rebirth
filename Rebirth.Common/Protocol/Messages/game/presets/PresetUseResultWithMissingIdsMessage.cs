


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PresetUseResultWithMissingIdsMessage : PresetUseResultMessage
{

public const uint Id = 6022;
public uint MessageId
{
    get { return Id; }
}

public uint[] missingIds;
        

public PresetUseResultWithMissingIdsMessage()
{
}

public PresetUseResultWithMissingIdsMessage(short presetId, sbyte code, uint[] missingIds)
         : base(presetId, code)
        {
            this.missingIds = missingIds;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)missingIds.Length);
            foreach (var entry in missingIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            missingIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 missingIds[i] = reader.ReadVarUhShort();
            }
            

}


}


}