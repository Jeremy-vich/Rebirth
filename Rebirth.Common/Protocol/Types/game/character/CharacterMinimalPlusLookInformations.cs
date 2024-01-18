


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class CharacterMinimalPlusLookInformations : CharacterMinimalInformations
{

public const short Id = 5838;
public override short TypeId
{
    get { return Id; }
}

public Types.EntityLook entityLook;
        public sbyte breed;
        

public CharacterMinimalPlusLookInformations()
{
}

public CharacterMinimalPlusLookInformations(double id, string name, uint level, Types.EntityLook entityLook, sbyte breed)
         : base(id, name, level)
        {
            this.entityLook = entityLook;
            this.breed = breed;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            entityLook.Serialize(writer);
            writer.WriteSbyte(breed);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            entityLook = new Types.EntityLook();
            entityLook.Deserialize(reader);
            breed = reader.ReadSbyte();
            

}


}


}