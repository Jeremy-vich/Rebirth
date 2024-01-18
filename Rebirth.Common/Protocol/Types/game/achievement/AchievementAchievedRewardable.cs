


















// Generated on 01/30/2023 13:09:30
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class AchievementAchievedRewardable : AchievementAchieved
{

public const short Id = 2637;
public override short TypeId
{
    get { return Id; }
}

public uint finishedlevel;
        

public AchievementAchievedRewardable()
{
}

public AchievementAchievedRewardable(uint id, double achievedBy, uint finishedlevel)
         : base(id, achievedBy)
        {
            this.finishedlevel = finishedlevel;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)finishedlevel);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            finishedlevel = reader.ReadVarUhShort();
            

}


}


}