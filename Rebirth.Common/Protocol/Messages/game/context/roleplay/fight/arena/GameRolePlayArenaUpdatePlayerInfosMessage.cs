


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayArenaUpdatePlayerInfosMessage : NetworkMessage
{

public const uint Id = 925;
public uint MessageId
{
    get { return Id; }
}

public Types.ArenaRankInfos solo;
        

public GameRolePlayArenaUpdatePlayerInfosMessage()
{
}

public GameRolePlayArenaUpdatePlayerInfosMessage(Types.ArenaRankInfos solo)
        {
            this.solo = solo;
        }
        

public void Serialize(IDataWriter writer)
{

solo.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

solo = new Types.ArenaRankInfos();
            solo.Deserialize(reader);
            

}


}


}