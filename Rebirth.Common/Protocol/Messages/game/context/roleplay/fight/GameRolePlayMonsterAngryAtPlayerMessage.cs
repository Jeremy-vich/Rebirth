


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayMonsterAngryAtPlayerMessage : NetworkMessage
{

public const uint Id = 6312;
public uint MessageId
{
    get { return Id; }
}

public double playerId;
        public double monsterGroupId;
        public double angryStartTime;
        public double attackTime;
        

public GameRolePlayMonsterAngryAtPlayerMessage()
{
}

public GameRolePlayMonsterAngryAtPlayerMessage(double playerId, double monsterGroupId, double angryStartTime, double attackTime)
        {
            this.playerId = playerId;
            this.monsterGroupId = monsterGroupId;
            this.angryStartTime = angryStartTime;
            this.attackTime = attackTime;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(playerId);
            writer.WriteDouble(monsterGroupId);
            writer.WriteDouble(angryStartTime);
            writer.WriteDouble(attackTime);
            

}

public void Deserialize(IDataReader reader)
{

playerId = reader.ReadVarUhLong();
            monsterGroupId = reader.ReadDouble();
            angryStartTime = reader.ReadDouble();
            attackTime = reader.ReadDouble();
            

}


}


}