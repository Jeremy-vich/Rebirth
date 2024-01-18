


















// Generated on 01/30/2023 13:09:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionFightLifePointsLostMessage : AbstractGameActionMessage
{

public const uint Id = 1167;
public uint MessageId
{
    get { return Id; }
}

public double targetId;
        public uint loss;
        public uint permanentDamages;
        public int elementId;
        

public GameActionFightLifePointsLostMessage()
{
}

public GameActionFightLifePointsLostMessage(uint actionId, double sourceId, double targetId, uint loss, uint permanentDamages, int elementId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.loss = loss;
            this.permanentDamages = permanentDamages;
            this.elementId = elementId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarInt((int)loss);
            writer.WriteVarInt((int)permanentDamages);
            writer.WriteVarInt((int)elementId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            loss = reader.ReadVarUhInt();
            permanentDamages = reader.ReadVarUhInt();
            elementId = reader.ReadVarInt();
            

}


}


}