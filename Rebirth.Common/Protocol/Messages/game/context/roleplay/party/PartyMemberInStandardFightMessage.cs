


















// Generated on 01/30/2023 13:09:18
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PartyMemberInStandardFightMessage : AbstractPartyMemberInFightMessage
{

public const uint Id = 6098;
public uint MessageId
{
    get { return Id; }
}

public Types.MapCoordinatesExtended fightMap;
        

public PartyMemberInStandardFightMessage()
{
}

public PartyMemberInStandardFightMessage(uint partyId, sbyte reason, double memberId, int memberAccountId, string memberName, uint fightId, int timeBeforeFightStart, Types.MapCoordinatesExtended fightMap)
         : base(partyId, reason, memberId, memberAccountId, memberName, fightId, timeBeforeFightStart)
        {
            this.fightMap = fightMap;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            fightMap.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            fightMap = new Types.MapCoordinatesExtended();
            fightMap.Deserialize(reader);
            

}


}


}