


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class CharacterCharacteristicForPreset : SimpleCharacterCharacteristicForPreset
{

public const short Id = 8283;
public override short TypeId
{
    get { return Id; }
}

public int stuff;
        

public CharacterCharacteristicForPreset()
{
}

public CharacterCharacteristicForPreset(string keyword, int @base, int additionnal, int stuff)
         : base(keyword, @base, additionnal)
        {
            this.stuff = stuff;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)stuff);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            stuff = reader.ReadVarInt();
            

}


}


}