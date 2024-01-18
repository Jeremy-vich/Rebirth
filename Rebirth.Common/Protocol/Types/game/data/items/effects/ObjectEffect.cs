


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ObjectEffect
{

public const short Id = 2375;
public virtual short TypeId
{
    get { return Id; }
}

public uint actionId;
        

public ObjectEffect()
{
}

public ObjectEffect(uint actionId)
        {
            this.actionId = actionId;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)actionId);
            

}

public virtual void Deserialize(IDataReader reader)
{

actionId = reader.ReadVarUhShort();
            

}


}


}