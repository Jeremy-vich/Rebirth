


















// Generated on 01/30/2023 13:09:30
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class AchievementObjective
{

public const short Id = 4324;
public virtual short TypeId
{
    get { return Id; }
}

public uint id;
        public uint maxValue;
        

public AchievementObjective()
{
}

public AchievementObjective(uint id, uint maxValue)
        {
            this.id = id;
            this.maxValue = maxValue;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)id);
            writer.WriteVarShort((int)maxValue);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhInt();
            maxValue = reader.ReadVarUhShort();
            

}


}


}