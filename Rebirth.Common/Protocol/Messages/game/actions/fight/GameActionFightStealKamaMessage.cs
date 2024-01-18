


















// Generated on 01/30/2023 13:09:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionFightStealKamaMessage : AbstractGameActionMessage
{

public const uint Id = 7363;
public uint MessageId
{
    get { return Id; }
}

public double targetId;
        public double amount;
        

public GameActionFightStealKamaMessage()
{
}

public GameActionFightStealKamaMessage(uint actionId, double sourceId, double targetId, double amount)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.amount = amount;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarLong(amount);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            amount = reader.ReadVarUhLong();
            

}


}


}