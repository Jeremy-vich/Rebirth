


















// Generated on 01/30/2023 13:09:19
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class WatchQuestStepInfoRequestMessage : QuestStepInfoRequestMessage
{

public const uint Id = 1902;
public uint MessageId
{
    get { return Id; }
}

public double playerId;
        

public WatchQuestStepInfoRequestMessage()
{
}

public WatchQuestStepInfoRequestMessage(uint questId, double playerId)
         : base(questId)
        {
            this.playerId = playerId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(playerId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            

}


}


}