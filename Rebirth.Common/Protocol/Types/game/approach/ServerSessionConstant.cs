


















// Generated on 01/30/2023 13:09:30
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ServerSessionConstant
{

public const short Id = 9098;
public virtual short TypeId
{
    get { return Id; }
}

public uint id;
        

public ServerSessionConstant()
{
}

public ServerSessionConstant(uint id)
        {
            this.id = id;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)id);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhShort();
            

}


}


}