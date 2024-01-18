


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightTurnEndMessage : NetworkMessage
{

public const uint Id = 3224;
public uint MessageId
{
    get { return Id; }
}

public double id;
        

public GameFightTurnEndMessage()
{
}

public GameFightTurnEndMessage(double id)
        {
            this.id = id;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(id);
            

}

public void Deserialize(IDataReader reader)
{

id = reader.ReadDouble();
            

}


}


}