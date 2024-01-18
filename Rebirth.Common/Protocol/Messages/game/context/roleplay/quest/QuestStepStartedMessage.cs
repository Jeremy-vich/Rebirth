


















// Generated on 01/30/2023 13:09:19
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class QuestStepStartedMessage : NetworkMessage
{

public const uint Id = 1639;
public uint MessageId
{
    get { return Id; }
}

public uint questId;
        public uint stepId;
        

public QuestStepStartedMessage()
{
}

public QuestStepStartedMessage(uint questId, uint stepId)
        {
            this.questId = questId;
            this.stepId = stepId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)questId);
            writer.WriteVarShort((int)stepId);
            

}

public void Deserialize(IDataReader reader)
{

questId = reader.ReadVarUhShort();
            stepId = reader.ReadVarUhShort();
            

}


}


}