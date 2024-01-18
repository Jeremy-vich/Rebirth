


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildFightPlayersEnemyRemoveMessage : NetworkMessage
{

public const uint Id = 5710;
public uint MessageId
{
    get { return Id; }
}

public double fightId;
        public double playerId;
        

public GuildFightPlayersEnemyRemoveMessage()
{
}

public GuildFightPlayersEnemyRemoveMessage(double fightId, double playerId)
        {
            this.fightId = fightId;
            this.playerId = playerId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(fightId);
            writer.WriteVarLong(playerId);
            

}

public void Deserialize(IDataReader reader)
{

fightId = reader.ReadDouble();
            playerId = reader.ReadVarUhLong();
            

}


}


}