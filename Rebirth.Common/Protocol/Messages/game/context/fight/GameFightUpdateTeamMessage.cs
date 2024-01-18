


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightUpdateTeamMessage : NetworkMessage
{

public const uint Id = 6345;
public uint MessageId
{
    get { return Id; }
}

public uint fightId;
        public Types.FightTeamInformations team;
        

public GameFightUpdateTeamMessage()
{
}

public GameFightUpdateTeamMessage(uint fightId, Types.FightTeamInformations team)
        {
            this.fightId = fightId;
            this.team = team;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)fightId);
            team.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

fightId = reader.ReadVarUhShort();
            team = new Types.FightTeamInformations();
            team.Deserialize(reader);
            

}


}


}