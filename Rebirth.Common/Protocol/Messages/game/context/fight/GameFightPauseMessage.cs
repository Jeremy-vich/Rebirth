


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightPauseMessage : NetworkMessage
{

public const uint Id = 4482;
public uint MessageId
{
    get { return Id; }
}

public bool isPaused;
        

public GameFightPauseMessage()
{
}

public GameFightPauseMessage(bool isPaused)
        {
            this.isPaused = isPaused;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(isPaused);
            

}

public void Deserialize(IDataReader reader)
{

isPaused = reader.ReadBoolean();
            

}


}


}