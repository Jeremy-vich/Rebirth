


















// Generated on 01/30/2023 13:09:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AchievementDetailedListMessage : NetworkMessage
{

public const uint Id = 8353;
public uint MessageId
{
    get { return Id; }
}

public Types.Achievement[] startedAchievements;
        public Types.Achievement[] finishedAchievements;
        

public AchievementDetailedListMessage()
{
}

public AchievementDetailedListMessage(Types.Achievement[] startedAchievements, Types.Achievement[] finishedAchievements)
        {
            this.startedAchievements = startedAchievements;
            this.finishedAchievements = finishedAchievements;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)startedAchievements.Length);
            foreach (var entry in startedAchievements)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)finishedAchievements.Length);
            foreach (var entry in finishedAchievements)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            startedAchievements = new Types.Achievement[limit];
            for (int i = 0; i < limit; i++)
            {
                 startedAchievements[i] = new Types.Achievement();
                 startedAchievements[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            finishedAchievements = new Types.Achievement[limit];
            for (int i = 0; i < limit; i++)
            {
                 finishedAchievements[i] = new Types.Achievement();
                 finishedAchievements[i].Deserialize(reader);
            }
            

}


}


}