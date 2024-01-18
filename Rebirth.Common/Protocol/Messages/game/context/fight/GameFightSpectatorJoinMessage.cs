


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightSpectatorJoinMessage : GameFightJoinMessage
{

public const uint Id = 7459;
public uint MessageId
{
    get { return Id; }
}

public Types.NamedPartyTeam[] namedPartyTeams;
        

public GameFightSpectatorJoinMessage()
{
}

public GameFightSpectatorJoinMessage(bool isTeamPhase, bool canBeCancelled, bool canSayReady, bool isFightStarted, short timeMaxBeforeFightStart, sbyte fightType, Types.NamedPartyTeam[] namedPartyTeams)
         : base(isTeamPhase, canBeCancelled, canSayReady, isFightStarted, timeMaxBeforeFightStart, fightType)
        {
            this.namedPartyTeams = namedPartyTeams;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)namedPartyTeams.Length);
            foreach (var entry in namedPartyTeams)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            namedPartyTeams = new Types.NamedPartyTeam[limit];
            for (int i = 0; i < limit; i++)
            {
                 namedPartyTeams[i] = new Types.NamedPartyTeam();
                 namedPartyTeams[i].Deserialize(reader);
            }
            

}


}


}