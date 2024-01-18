


















// Generated on 01/30/2023 13:09:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AchievementListMessage : NetworkMessage
{

public const uint Id = 5488;
public uint MessageId
{
    get { return Id; }
}

public Types.AchievementAchieved[] finishedAchievements;
        

public AchievementListMessage()
{
}

public AchievementListMessage(Types.AchievementAchieved[] finishedAchievements)
        {
            this.finishedAchievements = finishedAchievements;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)finishedAchievements.Length);
            foreach (var entry in finishedAchievements)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            finishedAchievements = new Types.AchievementAchieved[limit];
            for (int i = 0; i < limit; i++)
            {
                 finishedAchievements[i] = ProtocolTypeManager.GetInstance<Types.AchievementAchieved>(reader.ReadUShort());
                 finishedAchievements[i].Deserialize(reader);
            }
            

}


}


}