


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayAttackMonsterRequestMessage : NetworkMessage
{

public const uint Id = 9283;
public uint MessageId
{
    get { return Id; }
}

public double monsterGroupId;
        

public GameRolePlayAttackMonsterRequestMessage()
{
}

public GameRolePlayAttackMonsterRequestMessage(double monsterGroupId)
        {
            this.monsterGroupId = monsterGroupId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(monsterGroupId);
            

}

public void Deserialize(IDataReader reader)
{

monsterGroupId = reader.ReadDouble();
            

}


}


}