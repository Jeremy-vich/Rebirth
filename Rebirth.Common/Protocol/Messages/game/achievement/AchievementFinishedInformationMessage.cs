


















// Generated on 01/30/2023 13:09:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AchievementFinishedInformationMessage : AchievementFinishedMessage
{

public const uint Id = 8846;
public uint MessageId
{
    get { return Id; }
}

public string name;
        public double playerId;
        

public AchievementFinishedInformationMessage()
{
}

public AchievementFinishedInformationMessage(Types.AchievementAchievedRewardable achievement, string name, double playerId)
         : base(achievement)
        {
            this.name = name;
            this.playerId = playerId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteVarLong(playerId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            playerId = reader.ReadVarUhLong();
            

}


}


}