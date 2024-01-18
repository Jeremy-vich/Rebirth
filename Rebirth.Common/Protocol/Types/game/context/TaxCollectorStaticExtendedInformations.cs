


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class TaxCollectorStaticExtendedInformations : TaxCollectorStaticInformations
{

public const short Id = 2929;
public override short TypeId
{
    get { return Id; }
}

public Types.AllianceInformations allianceIdentity;
        

public TaxCollectorStaticExtendedInformations()
{
}

public TaxCollectorStaticExtendedInformations(uint firstNameId, uint lastNameId, Types.GuildInformations guildIdentity, double callerId, Types.AllianceInformations allianceIdentity)
         : base(firstNameId, lastNameId, guildIdentity, callerId)
        {
            this.allianceIdentity = allianceIdentity;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            allianceIdentity.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            allianceIdentity = new Types.AllianceInformations();
            allianceIdentity.Deserialize(reader);
            

}


}


}