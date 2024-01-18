


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class InteractiveElementNamedSkill : InteractiveElementSkill
{

public const short Id = 7491;
public override short TypeId
{
    get { return Id; }
}

public uint nameId;
        

public InteractiveElementNamedSkill()
{
}

public InteractiveElementNamedSkill(uint skillId, int skillInstanceUid, uint nameId)
         : base(skillId, skillInstanceUid)
        {
            this.nameId = nameId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)nameId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            nameId = reader.ReadVarUhInt();
            

}


}


}