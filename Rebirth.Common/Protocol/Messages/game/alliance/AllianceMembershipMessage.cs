


















// Generated on 01/30/2023 13:09:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceMembershipMessage : AllianceJoinedMessage
{

public const uint Id = 5434;
public uint MessageId
{
    get { return Id; }
}



public AllianceMembershipMessage()
{
}

public AllianceMembershipMessage(Types.AllianceInformations allianceInfo, bool enabled, uint leadingGuildId)
         : base(allianceInfo, enabled, leadingGuildId)
        {
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}