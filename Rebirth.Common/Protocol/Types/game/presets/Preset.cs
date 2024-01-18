


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class Preset
{

public const short Id = 4929;
public virtual short TypeId
{
    get { return Id; }
}

public short id;
        

public Preset()
{
}

public Preset(short id)
        {
            this.id = id;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteShort(id);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadShort();
            

}


}


}