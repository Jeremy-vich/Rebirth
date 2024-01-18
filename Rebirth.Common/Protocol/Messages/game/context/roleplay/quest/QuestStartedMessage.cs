


















// Generated on 01/30/2023 13:09:19
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class QuestStartedMessage : NetworkMessage
{

public const uint Id = 9791;
public uint MessageId
{
    get { return Id; }
}

public uint questId;
        

public QuestStartedMessage()
{
}

public QuestStartedMessage(uint questId)
        {
            this.questId = questId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)questId);
            

}

public void Deserialize(IDataReader reader)
{

questId = reader.ReadVarUhShort();
            

}


}


}