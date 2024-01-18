


















// Generated on 01/30/2023 13:09:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionFightDropCharacterMessage : AbstractGameActionMessage
{

public const uint Id = 9637;
public uint MessageId
{
    get { return Id; }
}

public double targetId;
        public short cellId;
        

public GameActionFightDropCharacterMessage()
{
}

public GameActionFightDropCharacterMessage(uint actionId, double sourceId, double targetId, short cellId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.cellId = cellId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteShort(cellId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            cellId = reader.ReadShort();
            

}


}


}