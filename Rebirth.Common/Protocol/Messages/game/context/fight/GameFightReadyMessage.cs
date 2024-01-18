


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightReadyMessage : NetworkMessage
{

public const uint Id = 5896;
public uint MessageId
{
    get { return Id; }
}

public bool isReady;
        

public GameFightReadyMessage()
{
}

public GameFightReadyMessage(bool isReady)
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