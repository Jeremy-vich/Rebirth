


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameContextActorInformations : GameContextActorPositionInformations
{

public const short Id = 6154;
public override short TypeId
{
    get { return Id; }
}

public Types.EntityLook look;
        

public GameContextActorInformations()
{
}

public GameContextActorInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look)
         : base(contextualId, disposition)
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