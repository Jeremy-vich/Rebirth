


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class MapCoordinates
{

public const short Id = 434;
public virtual short TypeId
{
    get { return Id; }
}

public short worldX;
        public short worldY;
        

public MapCoordinates()
{
}

public MapCoordinates(short worldX, short worldY)
        {
            this.worldX = worldX;
            this.worldY = worldY;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            

}

public virtual void Deserialize(IDataReader reader)
{

worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            

}


}


}