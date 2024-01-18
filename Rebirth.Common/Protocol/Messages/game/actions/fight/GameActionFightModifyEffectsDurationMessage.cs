


















// Generated on 01/30/2023 13:09:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionFightModifyEffectsDurationMessage : AbstractGameActionMessage
{

public const uint Id = 268;
public uint MessageId
{
    get { return Id; }
}

public double targetId;
        public short delta;
        

public GameActionFightModifyEffectsDurationMessage()
{
}

public GameActionFightModifyEffectsDurationMessage(uint actionId, double sourceId, double targetId, short delta)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.delta = delta;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteShort(delta);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            delta = reader.ReadShort();
            

}


}


}