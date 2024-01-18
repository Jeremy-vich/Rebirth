


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class MonsterInGroupInformations : MonsterInGroupLightInformations
{

public const short Id = 4170;
public override short TypeId
{
    get { return Id; }
}

public Types.EntityLook look;
        

public MonsterInGroupInformations()
{
}

public MonsterInGroupInformations(int genericId, sbyte grade, short level, Types.EntityLook look)
         : base(genericId, grade, level)
        {
            this.look = look;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            look.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            look = new Types.EntityLook();
            look.Deserialize(reader);
            

}


}


}