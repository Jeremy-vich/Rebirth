


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightPlacementSwapPositionsCancelledMessage : NetworkMessage
{

public const uint Id = 7803;
public uint MessageId
{
    get { return Id; }
}

public int requestId;
        public double cancellerId;
        

public GameFightPlacementSwapPositionsCancelledMessage()
{
}

public GameFightPlacementSwapPositionsCancelledMessage(int requestId, double cancellerId)
        {
            this.requestId = requestId;
            this.cancellerId = cancellerId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(requestId);
            writer.WriteDouble(cancellerId);
            

}

public void Deserialize(IDataReader reader)
{

requestId = reader.ReadInt();
            cancellerId = reader.ReadDouble();
            

}


}


}