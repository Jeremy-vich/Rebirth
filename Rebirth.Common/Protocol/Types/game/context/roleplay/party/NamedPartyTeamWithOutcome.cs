


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class NamedPartyTeamWithOutcome
{

public const short Id = 4812;
public virtual short TypeId
{
    get { return Id; }
}

public Types.NamedPartyTeam team;
        public uint outcome;
        

public NamedPartyTeamWithOutcome()
{
}

public NamedPartyTeamWithOutcome(Types.NamedPartyTeam team, uint outcome)
        {
            this.team = team;
            this.outcome = outcome;
        }
        

public virtual void Serialize(IDataWriter writer)
{

team.Serialize(writer);
            writer.WriteVarShort((int)outcome);
            

}

public virtual void Deserialize(IDataReader reader)
{

team = new Types.NamedPartyTeam();
            team.Deserialize(reader);
            outcome = reader.ReadVarUhShort();
            

}


}


}