


















// Generated on 01/30/2023 13:09:19
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class QuestObjectiveValidationMessage : NetworkMessage
{

public const uint Id = 3507;
public uint MessageId
{
    get { return Id; }
}

public uint questId;
        public uint objectiveId;
        

public QuestObjectiveValidationMessage()
{
}

public QuestObjectiveValidationMessage(uint questId, uint objectiveId)
        {
            this.questId = questId;
            this.objectiveId = objectiveId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)questId);
            writer.WriteVarShort((int)objectiveId);
            

}

public void Deserialize(IDataReader reader)
{

questId = reader.ReadVarUhShort();
            objectiveId = reader.ReadVarUhShort();
            

}


}


}