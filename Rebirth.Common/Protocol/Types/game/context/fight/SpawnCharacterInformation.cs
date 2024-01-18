


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class SpawnCharacterInformation : SpawnInformation
{

public const short Id = 4647;
public override short TypeId
{
    get { return Id; }
}

public string name;
        public uint level;
        

public SpawnCharacterInformation()
{
}

public SpawnCharacterInformation(string name, uint level)
        {
            this.name = name;
            this.level = level;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteVarShort((int)level);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            level = reader.ReadVarUhShort();
            

}


}


}