


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class UpdateMountIntegerCharacteristic : UpdateMountCharacteristic
{

public const short Id = 3041;
public override short TypeId
{
    get { return Id; }
}

public int value;
        

public UpdateMountIntegerCharacteristic()
{
}

public UpdateMountIntegerCharacteristic(sbyte type, int value)
         : base(type)
        {
            this.value = value;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(value);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadInt();
            

}


}


}