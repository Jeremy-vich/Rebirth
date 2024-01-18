


















// Generated on 01/30/2023 13:09:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionFightReduceDamagesMessage : AbstractGameActionMessage
{

public const uint Id = 8445;
public uint MessageId
{
    get { return Id; }
}

public double targetId;
        public uint amount;
        

public GameActionFightReduceDamagesMessage()
{
}

public GameActionFightReduceDamagesMessage(uint actionId, double sourceId, double targetId, uint amount)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.amount = amount;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarInt((int)amount);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            amount = reader.ReadVarUhInt();
            

}


}


}