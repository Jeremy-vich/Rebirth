


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class MapCoordinatesAndId : MapCoordinates
{

public const short Id = 9300;
public override short TypeId
{
    get { return Id; }
}

public double mapId;
        

public MapCoordinatesAndId()
{
}

public MapCoordinatesAndId(short worldX, short worldY, double mapId)
         : base(worldX, worldY)
        {
            this.mapId = mapId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(mapId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            mapId = reader.ReadDouble();
            

}


}


}