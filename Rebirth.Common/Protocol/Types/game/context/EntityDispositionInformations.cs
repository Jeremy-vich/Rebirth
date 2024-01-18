


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class EntityDispositionInformations
{

public const short Id = 6822;
public virtual short TypeId
{
    get { return Id; }
}

public short cellId;
        public sbyte direction;
        

public EntityDispositionInformations()
{
}

public EntityDispositionInformations(short cellId, sbyte direction)
        {
            this.cellId = cellId;
            this.direction = direction;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteShort(cellId);
            writer.WriteSbyte(direction);
            

}

public virtual void Deserialize(IDataReader reader)
{

cellId = reader.ReadShort();
            direction = reader.ReadSbyte();
            

}


}


}