


















// Generated on 01/30/2023 13:09:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionFightExchangePositionsMessage : AbstractGameActionMessage
{

public const uint Id = 1091;
public uint MessageId
{
    get { return Id; }
}

public double targetId;
        public short casterCellId;
        public short targetCellId;
        

public GameActionFightExchangePositionsMessage()
{
}

public GameActionFightExchangePositionsMessage(uint actionId, double sourceId, double targetId, short casterCellId, short targetCellId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.casterCellId = casterCellId;
            this.targetCellId = targetCellId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteShort(casterCellId);
            writer.WriteShort(targetCellId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            casterCellId = reader.ReadShort();
            targetCellId = reader.ReadShort();
            

}


}


}