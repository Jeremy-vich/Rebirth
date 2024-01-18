


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class CharacterCharacteristic
{

public const short Id = 3999;
public virtual short TypeId
{
    get { return Id; }
}

public short characteristicId;
        

public CharacterCharacteristic()
{
}

public CharacterCharacteristic(short characteristicId)
        {
            this.characteristicId = characteristicId;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteShort(characteristicId);
            

}

public virtual void Deserialize(IDataReader reader)
{

characteristicId = reader.ReadShort();
            

}


}


}