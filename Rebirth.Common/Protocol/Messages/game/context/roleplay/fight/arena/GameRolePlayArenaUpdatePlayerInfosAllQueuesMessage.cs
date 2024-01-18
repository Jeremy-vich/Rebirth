


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayArenaUpdatePlayerInfosAllQueuesMessage : GameRolePlayArenaUpdatePlayerInfosMessage
{

public const uint Id = 6951;
public uint MessageId
{
    get { return Id; }
}

public Types.ArenaRankInfos team;
        public Types.ArenaRankInfos duel;
        

public GameRolePlayArenaUpdatePlayerInfosAllQueuesMessage()
{
}

public GameRolePlayArenaUpdatePlayerInfosAllQueuesMessage(Types.ArenaRankInfos solo, Types.ArenaRankInfos team, Types.ArenaRankInfos duel)
         : base(solo)
        {
            this.team = team;
            this.duel = duel;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            team.Serialize(writer);
            duel.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            team = new Types.ArenaRankInfos();
            team.Deserialize(reader);
            duel = new Types.ArenaRankInfos();
            duel.Deserialize(reader);
            

}


}


}