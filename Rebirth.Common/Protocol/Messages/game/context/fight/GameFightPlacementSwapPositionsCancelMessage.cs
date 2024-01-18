


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightPlacementSwapPositionsCancelMessage : NetworkMessage
{

public const uint Id = 67;
public uint MessageId
{
    get { return Id; }
}

public int requestId;
        

public GameFightPlacementSwapPositionsCancelMessage()
{
}

public GameFightPlacementSwapPositionsCancelMessage(int requestId)
        {
            this.requestId = requestId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(requestId);
            

}

public void Deserialize(IDataReader reader)
{

requestId = reader.ReadInt();
            

}


}


}