


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class SkillActionDescription
{

public const short Id = 2029;
public virtual short TypeId
{
    get { return Id; }
}

public uint skillId;
        

public SkillActionDescription()
{
}

public SkillActionDescription(uint skillId)
        {
            this.skillId = skillId;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)skillId);
            

}

public virtual void Deserialize(IDataReader reader)
{

skillId = reader.ReadVarUhShort();
            

}


}


}