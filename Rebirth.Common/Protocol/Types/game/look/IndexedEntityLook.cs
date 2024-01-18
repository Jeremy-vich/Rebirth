


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class IndexedEntityLook
{

public const short Id = 1690;
public virtual short TypeId
{
    get { return Id; }
}

public Types.EntityLook look;
        public sbyte index;
        

public IndexedEntityLook()
{
}

public IndexedEntityLook(Types.EntityLook look, sbyte index)
        {
            this.look = look;
            this.index = index;
        }
        

public virtual void Serialize(IDataWriter writer)
{

look.Serialize(writer);
            writer.WriteSbyte(index);
            

}

public virtual void Deserialize(IDataReader reader)
{

look = new Types.EntityLook();
            look.Deserialize(reader);
            index = reader.ReadSbyte();
            

}


}


}