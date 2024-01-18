


















// Generated on 01/30/2023 13:09:30
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class AchievementStartedObjective : AchievementObjective
{

public const short Id = 6750;
public override short TypeId
{
    get { return Id; }
}

public uint value;
        

public AchievementStartedObjective()
{
}

public AchievementStartedObjective(uint id, uint maxValue, uint value)
         : base(id, maxValue)
        {
            this.value = value;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)value);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadVarUhShort();
            

}


}


}