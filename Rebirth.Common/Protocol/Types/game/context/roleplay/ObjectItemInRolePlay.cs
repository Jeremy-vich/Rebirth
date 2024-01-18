


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ObjectItemInRolePlay
{

public const short Id = 7139;
public virtual short TypeId
{
    get { return Id; }
}

public uint cellId;
        public uint objectGID;
        

public ObjectItemInRolePlay()
{
}

public ObjectItemInRolePlay(uint cellId, uint objectGID)
        {
            this.cellId = cellId;
            this.objectGID = objectGID;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)cellId);
            writer.WriteVarInt((int)objectGID);
            

}

public virtual void Deserialize(IDataReader reader)
{

cellId = reader.ReadVarUhShort();
            objectGID = reader.ReadVarUhInt();
            

}


}


}