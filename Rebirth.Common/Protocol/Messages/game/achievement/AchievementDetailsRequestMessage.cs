


















// Generated on 01/30/2023 13:09:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AchievementDetailsRequestMessage : NetworkMessage
{

public const uint Id = 2445;
public uint MessageId
{
    get { return Id; }
}

public uint achievementId;
        

public AchievementDetailsRequestMessage()
{
}

public AchievementDetailsRequestMessage(uint achievementId)
        {
            this.achievementId = achievementId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)achievementId);
            

}

public void Deserialize(IDataReader reader)
{

achievementId = reader.ReadVarUhShort();
            

}


}


}