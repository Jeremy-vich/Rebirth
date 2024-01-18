


















// Generated on 01/30/2023 13:09:19
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class QuestListMessage : NetworkMessage
{

public const uint Id = 5228;
public uint MessageId
{
    get { return Id; }
}

public uint[] finishedQuestsIds;
        public uint[] finishedQuestsCounts;
        public Types.QuestActiveInformations[] activeQuests;
        public uint[] reinitDoneQuestsIds;
        

public QuestListMessage()
{
}

public QuestListMessage(uint[] finishedQuestsIds, uint[] finishedQuestsCounts, Types.QuestActiveInformations[] activeQuests, uint[] reinitDoneQuestsIds)
        {
            this.finishedQuestsIds = finishedQuestsIds;
            this.finishedQuestsCounts = finishedQuestsCounts;
            this.activeQuests = activeQuests;
            this.reinitDoneQuestsIds = reinitDoneQuestsIds;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)finishedQuestsIds.Length);
            foreach (var entry in finishedQuestsIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)finishedQuestsCounts.Length);
            foreach (var entry in finishedQuestsCounts)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)activeQuests.Length);
            foreach (var entry in activeQuests)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)reinitDoneQuestsIds.Length);
            foreach (var entry in reinitDoneQuestsIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            finishedQuestsIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 finishedQuestsIds[i] = reader.ReadVarUhShort();
            }
            limit = (ushort)reader.ReadUShort();
            finishedQuestsCounts = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 finishedQuestsCounts[i] = reader.ReadVarUhShort();
            }
            limit = (ushort)reader.ReadUShort();
            activeQuests = new Types.QuestActiveInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 activeQuests[i] = ProtocolTypeManager.GetInstance<Types.QuestActiveInformations>(reader.ReadUShort());
                 activeQuests[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            reinitDoneQuestsIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 reinitDoneQuestsIds[i] = reader.ReadVarUhShort();
            }
            

}


}


}