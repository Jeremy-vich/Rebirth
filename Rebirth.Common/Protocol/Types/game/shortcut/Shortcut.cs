


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class Shortcut
{

public const short Id = 3762;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte slot;
        

public Shortcut()
{
}

public Shortcut(sbyte slot)
        {
            this.slot = slot;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(slot);
            

}

public virtual void Deserialize(IDataReader reader)
{

slot = reader.ReadSbyte();
            

}


}


}