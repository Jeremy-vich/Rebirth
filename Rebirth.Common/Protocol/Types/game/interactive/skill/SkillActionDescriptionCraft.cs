


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class SkillActionDescriptionCraft : SkillActionDescription
{

public const short Id = 1139;
public override short TypeId
{
    get { return Id; }
}

public sbyte probability;
        

public SkillActionDescriptionCraft()
{
}

public SkillActionDescriptionCraft(uint skillId, sbyte probability)
         : base(skillId)
        {
            this.probability = probability;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(probability);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            probability = reader.ReadSbyte();
            

}


}


}