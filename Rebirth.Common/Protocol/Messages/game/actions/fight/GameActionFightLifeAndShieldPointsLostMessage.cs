


















// Generated on 01/30/2023 13:09:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionFightLifeAndShieldPointsLostMessage : GameActionFightLifePointsLostMessage
{

public const uint Id = 5970;
public uint MessageId
{
    get { return Id; }
}

public uint shieldLoss;
        

public GameActionFightLifeAndShieldPointsLostMessage()
{
}

public GameActionFightLifeAndShieldPointsLostMessage(uint actionId, double sourceId, double targetId, uint loss, uint permanentDamages, int elementId, uint shieldLoss)
         : base(actionId, sourceId, targetId, loss, permanentDamages, elementId)
        {
            this.shieldLoss = shieldLoss;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)shieldLoss);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            shieldLoss = reader.ReadVarUhShort();
            

}


}


}