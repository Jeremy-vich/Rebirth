


















// Generated on 01/30/2023 13:09:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AchievementRewardSuccessMessage : NetworkMessage
{

public const uint Id = 9076;
public uint MessageId
{
    get { return Id; }
}

public short achievementId;
        

public AchievementRewardSuccessMessage()
{
}

public AchievementRewardSuccessMessage(short achievementId)
        {
            this.achievementId = achievementId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(achievementId);
            

}

public void Deserialize(IDataReader reader)
{

achievementId = reader.ReadShort();
            

}


}


}