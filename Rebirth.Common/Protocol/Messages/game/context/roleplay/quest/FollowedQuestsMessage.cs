


















// Generated on 01/30/2023 13:09:19
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class FollowedQuestsMessage : NetworkMessage
{

public const uint Id = 3035;
public uint MessageId
{
    get { return Id; }
}

public Types.QuestActiveDetailedInformations[] quests;
        

public FollowedQuestsMessage()
{
}

public FollowedQuestsMessage(Types.QuestActiveDetailedInformations[] quests)
        {
            this.quests = quests;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)quests.Length);
            foreach (var entry in quests)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            quests = new Types.QuestActiveDetailedInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 quests[i] = new Types.QuestActiveDetailedInformations();
                 quests[i].Deserialize(reader);
            }
            

}


}


}