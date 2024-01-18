


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ZaapRespawnUpdatedMessage : NetworkMessage
{

public const uint Id = 2498;
public uint MessageId
{
    get { return Id; }
}

public double mapId;
        

public ZaapRespawnUpdatedMessage()
{
}

public ZaapRespawnUpdatedMessage(double mapId)
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