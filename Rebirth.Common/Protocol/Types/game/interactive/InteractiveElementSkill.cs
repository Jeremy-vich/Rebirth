


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class InteractiveElementSkill
{

public const short Id = 9259;
public virtual short TypeId
{
    get { return Id; }
}

public uint skillId;
        public int skillInstanceUid;
        

public InteractiveElementSkill()
{
}

public InteractiveElementSkill(uint skillId, int skillInstanceUid)
        {
            this.skillId = skillId;
            this.skillInstanceUid = skillInstanceUid;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)skillId);
            writer.WriteInt(skillInstanceUid);
            

}

public virtual void Deserialize(IDataReader reader)
{

skillId = reader.ReadVarUhInt();
            skillInstanceUid = reader.ReadInt();
            

}


}


}