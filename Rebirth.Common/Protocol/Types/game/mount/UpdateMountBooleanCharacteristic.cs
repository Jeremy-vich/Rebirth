


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class UpdateMountBooleanCharacteristic : UpdateMountCharacteristic
{

public const short Id = 1498;
public override short TypeId
{
    get { return Id; }
}

public bool value;
        

public UpdateMountBooleanCharacteristic()
{
}

public UpdateMountBooleanCharacteristic(sbyte type, bool value)
         : base(type)
        {
            this.value = value;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(value);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadBoolean();
            

}


}


}