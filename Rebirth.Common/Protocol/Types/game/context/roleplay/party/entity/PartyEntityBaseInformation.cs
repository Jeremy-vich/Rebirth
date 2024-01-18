


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class PartyEntityBaseInformation
{

public const short Id = 1277;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte indexId;
        public sbyte entityModelId;
        public Types.EntityLook entityLook;
        

public PartyEntityBaseInformation()
{
}

public PartyEntityBaseInformation(sbyte indexId, sbyte entityModelId, Types.EntityLook entityLook)
        {
            this.indexId = indexId;
            this.entityModelId = entityModelId;
            this.entityLook = entityLook;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(indexId);
            writer.WriteSbyte(entityModelId);
            entityLook.Serialize(writer);
            

}

public virtual void Deserialize(IDataReader reader)
{

indexId = reader.ReadSbyte();
            entityModelId = reader.ReadSbyte();
            entityLook = new Types.EntityLook();
            entityLook.Deserialize(reader);
            

}


}


}