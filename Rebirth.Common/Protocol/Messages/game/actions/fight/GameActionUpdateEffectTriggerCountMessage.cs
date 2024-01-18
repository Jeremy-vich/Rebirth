


















// Generated on 01/30/2023 13:09:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionUpdateEffectTriggerCountMessage : NetworkMessage
{

public const uint Id = 1601;
public uint MessageId
{
    get { return Id; }
}

public Types.GameFightEffectTriggerCount[] targetIds;
        

public GameActionUpdateEffectTriggerCountMessage()
{
}

public GameActionUpdateEffectTriggerCountMessage(Types.GameFightEffectTriggerCount[] targetIds)
        {
            this.targetIds = targetIds;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)targetIds.Length);
            foreach (var entry in targetIds)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            targetIds = new Types.GameFightEffectTriggerCount[limit];
            for (int i = 0; i < limit; i++)
            {
                 targetIds[i] = new Types.GameFightEffectTriggerCount();
                 targetIds[i].Deserialize(reader);
            }
            

}


}


}