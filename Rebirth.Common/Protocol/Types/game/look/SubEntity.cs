


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class SubEntity
{

public const short Id = 2388;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte bindingPointCategory;
        public sbyte bindingPointIndex;
        public Types.EntityLook subEntityLook;
        

public SubEntity()
{
}

public SubEntity(sbyte bindingPointCategory, sbyte bindingPointIndex, Types.EntityLook subEntityLook)
        {
            this.bindingPointCategory = bindingPointCategory;
            this.bindingPointIndex = bindingPointIndex;
            this.subEntityLook = subEntityLook;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(bindingPointCategory);
            writer.WriteSbyte(bindingPointIndex);
            subEntityLook.Serialize(writer);
            

}

public virtual void Deserialize(IDataReader reader)
{

bindingPointCategory = reader.ReadSbyte();
            bindingPointIndex = reader.ReadSbyte();
            subEntityLook = new Types.EntityLook();
            subEntityLook.Deserialize(reader);
            

}


}


}