


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayMonsterNotAngryAtPlayerMessage : NetworkMessage
{

public const uint Id = 2005;
public uint MessageId
{
    get { return Id; }
}

public double playerId;
        public double monsterGroupId;
        

public GameRolePlayMonsterNotAngryAtPlayerMessage()
{
}

public GameRolePlayMonsterNotAngryAtPlayerMessage(double playerId, double monsterGroupId)
        {
            this.playerId = playerId;
            this.monsterGroupId = monsterGroupId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(playerId);
            writer.WriteDouble(monsterGroupId);
            

}

public void Deserialize(IDataReader reader)
{

playerId = reader.ReadVarUhLong();
            monsterGroupId = reader.ReadDouble();
            

}


}


}