


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class CharacterCharacteristicValue : CharacterCharacteristic
{

public const short Id = 6375;
public override short TypeId
{
    get { return Id; }
}

public int total;
        

public CharacterCharacteristicValue()
{
}

public CharacterCharacteristicValue(short characteristicId, int total)
         : base(characteristicId)
        {
            this.total = total;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(total);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            total = reader.ReadInt();
            

}


}


}