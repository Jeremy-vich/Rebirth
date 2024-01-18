


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class MapCoordinatesExtended : MapCoordinatesAndId
{

public const short Id = 892;
public override short TypeId
{
    get { return Id; }
}

public uint subAreaId;
        

public MapCoordinatesExtended()
{
}

public MapCoordinatesExtended(short worldX, short worldY, double mapId, uint subAreaId)
         : base(worldX, worldY, mapId)
        {
            this.subAreaId = subAreaId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)subAreaId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            subAreaId = reader.ReadVarUhShort();
            

}


}


}