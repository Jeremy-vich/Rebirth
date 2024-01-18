


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class SkillActionDescriptionTimed : SkillActionDescription
{

public const short Id = 4372;
public override short TypeId
{
    get { return Id; }
}

public byte time;
        

public SkillActionDescriptionTimed()
{
}

public SkillActionDescriptionTimed(uint skillId, byte time)
         : base(skillId)
        {
            this.time = time;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteByte(time);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            time = reader.ReadByte();
            

}


}


}