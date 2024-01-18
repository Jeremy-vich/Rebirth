


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameRolePlayNamedActorInformations : GameRolePlayActorInformations
{

public const short Id = 4532;
public override short TypeId
{
    get { return Id; }
}

public string name;
        

public GameRolePlayNamedActorInformations()
{
}

public GameRolePlayNamedActorInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, string name)
         : base(contextualId, disposition, look)
        {
            this.name = name;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            

}


}


}