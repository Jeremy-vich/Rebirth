


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class FinishMoveSetRequestMessage : NetworkMessage
{

public const uint Id = 4451;
public uint MessageId
{
    get { return Id; }
}

public int finishMoveId;
        public bool finishMoveState;
        

public FinishMoveSetRequestMessage()
{
}

public FinishMoveSetRequestMessage(int finishMoveId, bool finishMoveState)
        {
            this.finishMoveId = finishMoveId;
            this.finishMoveState = finishMoveState;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(finishMoveId);
            writer.WriteBoolean(finishMoveState);
            

}

public void Deserialize(IDataReader reader)
{

finishMoveId = reader.ReadInt();
            finishMoveState = reader.ReadBoolean();
            

}


}


}