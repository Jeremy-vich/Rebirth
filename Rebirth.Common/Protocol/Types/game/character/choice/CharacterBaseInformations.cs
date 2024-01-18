


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class CharacterBaseInformations : CharacterMinimalPlusLookInformations
{

public const short Id = 3972;
public override short TypeId
{
    get { return Id; }
}

public bool sex;
        

public CharacterBaseInformations()
{
}

public CharacterBaseInformations(double id, string name, uint level, Types.EntityLook entityLook, sbyte breed, bool sex)
         : base(id, name, level, entityLook, breed)
        {
            this.sex = sex;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(sex);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            sex = reader.ReadBoolean();
            

}


}


}