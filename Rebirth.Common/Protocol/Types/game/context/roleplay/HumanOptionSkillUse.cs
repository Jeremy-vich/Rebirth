


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class HumanOptionSkillUse : HumanOption
{

public const short Id = 1413;
public override short TypeId
{
    get { return Id; }
}

public uint elementId;
        public uint skillId;
        public double skillEndTime;
        

public HumanOptionSkillUse()
{
}

public HumanOptionSkillUse(uint elementId, uint skillId, double skillEndTime)
        {
            this.elementId = elementId;
            this.skillId = skillId;
            this.skillEndTime = skillEndTime;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)elementId);
            writer.WriteVarShort((int)skillId);
            writer.WriteDouble(skillEndTime);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            elementId = reader.ReadVarUhInt();
            skillId = reader.ReadVarUhShort();
            skillEndTime = reader.ReadDouble();
            

}


}


}