


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class UpdateMountCharacteristic
{

public const short Id = 9715;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte type;
        

public UpdateMountCharacteristic()
{
}

public UpdateMountCharacteristic(sbyte type)
        {
            this.type = type;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(type);
            

}

public virtual void Deserialize(IDataReader reader)
{

type = reader.ReadSbyte();
            

}


}


}