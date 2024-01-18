


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayAggressionMessage : NetworkMessage
{

public const uint Id = 3544;
public uint MessageId
{
    get { return Id; }
}

public double attackerId;
        public double defenderId;
        

public GameRolePlayAggressionMessage()
{
}

public GameRolePlayAggressionMessage(double attackerId, double defenderId)
        {
            this.attackerId = attackerId;
            this.defenderId = defenderId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(attackerId);
            writer.WriteVarLong(defenderId);
            

}

public void Deserialize(IDataReader reader)
{

attackerId = reader.ReadVarUhLong();
            defenderId = reader.ReadVarUhLong();
            

}


}


}