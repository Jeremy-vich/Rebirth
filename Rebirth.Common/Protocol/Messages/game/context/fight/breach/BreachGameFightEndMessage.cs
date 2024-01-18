


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BreachGameFightEndMessage : GameFightEndMessage
{

public const uint Id = 9349;
public uint MessageId
{
    get { return Id; }
}

public int budget;
        

public BreachGameFightEndMessage()
{
}

public BreachGameFightEndMessage(int duration, int rewardRate, short lootShareLimitMalus, Types.FightResultListEntry[] results, Types.NamedPartyTeamWithOutcome[] namedPartyTeamsOutcomes, int budget)
         : base(duration, rewardRate, lootShareLimitMalus, results, namedPartyTeamsOutcomes)
        {
            this.budget = budget;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(budget);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            budget = reader.ReadInt();
            

}


}


}