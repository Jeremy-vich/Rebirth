


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class AllianceInformations : BasicNamedAllianceInformations
{

public const short Id = 1445;
public override short TypeId
{
    get { return Id; }
}

public Types.GuildEmblem allianceEmblem;
        

public AllianceInformations()
{
}

public AllianceInformations(uint allianceId, string allianceTag, string allianceName, Types.GuildEmblem allianceEmblem)
         : base(allianceId, allianceTag, allianceName)
        {
            this.allianceEmblem = allianceEmblem;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            allianceEmblem.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            allianceEmblem = new Types.GuildEmblem();
            allianceEmblem.Deserialize(reader);
            

}


}


}