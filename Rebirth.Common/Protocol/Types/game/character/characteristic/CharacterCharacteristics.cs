


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class CharacterCharacteristics
{

public const short Id = 9878;
public virtual short TypeId
{
    get { return Id; }
}

public Types.CharacterCharacteristic[] characteristics;
        

public CharacterCharacteristics()
{
}

public CharacterCharacteristics(Types.CharacterCharacteristic[] characteristics)
        {
            this.characteristics = characteristics;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteShort((short)characteristics.Length);
            foreach (var entry in characteristics)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public virtual void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            characteristics = new Types.CharacterCharacteristic[limit];
            for (int i = 0; i < limit; i++)
            {
                 characteristics[i] = ProtocolTypeManager.GetInstance<Types.CharacterCharacteristic>(reader.ReadUShort());
                 characteristics[i].Deserialize(reader);
            }
            

}


}


}