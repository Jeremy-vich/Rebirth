


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightTurnReadyMessage : NetworkMessage
{

public const uint Id = 2472;
public uint MessageId
{
    get { return Id; }
}

public bool isReady;
        

public GameFightTurnReadyMessage()
{
}

public GameFightTurnReadyMessage(bool isReady)
        {
            this.isReady = isReady;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(isReady);
            

}

public void Deserialize(IDataReader reader)
{

isReady = reader.ReadBoolean();
            

}


}


}