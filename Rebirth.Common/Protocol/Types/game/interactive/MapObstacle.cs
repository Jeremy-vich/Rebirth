


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class MapObstacle
{

public const short Id = 9250;
public virtual short TypeId
{
    get { return Id; }
}

public uint obstacleCellId;
        public sbyte state;
        

public MapObstacle()
{
}

public MapObstacle(uint obstacleCellId, sbyte state)
        {
            this.obstacleCellId = obstacleCellId;
            this.state = state;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)obstacleCellId);
            writer.WriteSbyte(state);
            

}

public virtual void Deserialize(IDataReader reader)
{

obstacleCellId = reader.ReadVarUhShort();
            state = reader.ReadSbyte();
            

}


}


}