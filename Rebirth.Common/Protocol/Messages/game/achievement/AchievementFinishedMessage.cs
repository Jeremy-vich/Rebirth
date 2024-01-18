


















// Generated on 01/30/2023 13:09:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AchievementFinishedMessage : NetworkMessage
{

public const uint Id = 6042;
public uint MessageId
{
    get { return Id; }
}

public Types.AchievementAchievedRewardable achievement;
        

public AchievementFinishedMessage()
{
}

public AchievementFinishedMessage(Types.AchievementAchievedRewardable achievement)
        {
            this.achievement = achievement;
        }
        

public void Serialize(IDataWriter writer)
{

achievement.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

achievement = new Types.AchievementAchievedRewardable();
            achievement.Deserialize(reader);
            

}


}


}