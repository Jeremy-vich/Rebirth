


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MapInformationsRequestMessage : NetworkMessage
{

public const uint Id = 8121;
public uint MessageId
{
    get { return Id; }
}

public double mapId;
        

public MapInformationsRequestMessage()
{
}

public MapInformationsRequestMessage(double mapId)
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