


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class FightTeamMemberInformations
{

public const short Id = 8044;
public virtual short TypeId
{
    get { return Id; }
}

public double id;
        

public FightTeamMemberInformations()
{
}

public FightTeamMemberInformations(double id)
        {
            this.id = id;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteDouble(id);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadDouble();
            

}


}


}