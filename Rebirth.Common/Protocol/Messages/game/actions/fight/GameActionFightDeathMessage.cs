


















// Generated on 01/30/2023 13:09:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionFightDeathMessage : AbstractGameActionMessage
{

public const uint Id = 4961;
public uint MessageId
{
    get { return Id; }
}

public double targetId;
        

public GameActionFightDeathMessage()
{
}

public GameActionFightDeathMessage(uint actionId, double sourceId, double targetId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            

}


}


}