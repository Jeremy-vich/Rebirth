


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayArenaFighterStatusMessage : NetworkMessage
{

public const uint Id = 2258;
public uint MessageId
{
    get { return Id; }
}

public uint fightId;
        public double playerId;
        public bool accepted;
        

public GameRolePlayArenaFighterStatusMessage()
{
}

public GameRolePlayArenaFighterStatusMessage(uint fightId, double playerId, bool accepted)
        {
            this.fightId = fightId;
            this.playerId = playerId;
            this.accepted = accepted;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)fightId);
            writer.WriteVarLong(playerId);
            writer.WriteBoolean(accepted);
            

}

public void Deserialize(IDataReader reader)
{

fightId = reader.ReadVarUhShort();
            playerId = reader.ReadVarUhLong();
            accepted = reader.ReadBoolean();
            

}


}


}