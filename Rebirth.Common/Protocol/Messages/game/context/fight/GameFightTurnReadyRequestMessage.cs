


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightTurnReadyRequestMessage : NetworkMessage
{

public const uint Id = 4303;
public uint MessageId
{
    get { return Id; }
}

public double id;
        

public GameFightTurnReadyRequestMessage()
{
}

public GameFightTurnReadyRequestMessage(double id)
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