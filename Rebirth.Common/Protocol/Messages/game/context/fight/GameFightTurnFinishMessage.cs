


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightTurnFinishMessage : NetworkMessage
{

public const uint Id = 703;
public uint MessageId
{
    get { return Id; }
}

public bool isAfk;
        

public GameFightTurnFinishMessage()
{
}

public GameFightTurnFinishMessage(bool isAfk)
        {
            this.isAfk = isAfk;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(isAfk);
            

}

public void Deserialize(IDataReader reader)
{

isAfk = reader.ReadBoolean();
            

}


}


}