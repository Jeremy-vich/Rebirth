


















// Generated on 01/30/2023 13:09:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AchievementDetailsMessage : NetworkMessage
{

public const uint Id = 983;
public uint MessageId
{
    get { return Id; }
}

public Types.Achievement achievement;
        

public AchievementDetailsMessage()
{
}

public AchievementDetailsMessage(Types.Achievement achievement)
        {
            this.achievement = achievement;
        }
        

public void Serialize(IDataWriter writer)
{

achievement.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

achievement = new Types.Achievement();
            achievement.Deserialize(reader);
            

}


}


}