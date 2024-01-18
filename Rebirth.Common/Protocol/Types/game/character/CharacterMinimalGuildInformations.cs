


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class CharacterMinimalGuildInformations : CharacterMinimalPlusLookInformations
{

public const short Id = 6211;
public override short TypeId
{
    get { return Id; }
}

public Types.BasicGuildInformations guild;
        

public CharacterMinimalGuildInformations()
{
}

public CharacterMinimalGuildInformations(double id, string name, uint level, Types.EntityLook entityLook, sbyte breed, Types.BasicGuildInformations guild)
         : base(id, name, level, entityLook, breed)
        {
            this.guild = guild;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            guild.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            guild = new Types.BasicGuildInformations();
            guild.Deserialize(reader);
            

}


}


}