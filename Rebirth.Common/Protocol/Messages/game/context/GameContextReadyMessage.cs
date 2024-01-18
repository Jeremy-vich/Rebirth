


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameContextReadyMessage : NetworkMessage
{

public const uint Id = 2609;
public uint MessageId
{
    get { return Id; }
}

public double mapId;
        

public GameContextReadyMessage()
{
}

public GameContextReadyMessage(double mapId)
        {
            this.mapId = mapId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(mapId);
            

}

public void Deserialize(IDataReader reader)
{

mapId = reader.ReadDouble();
            

}


}


}