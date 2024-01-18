


















// Generated on 01/30/2023 13:09:30
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class PlayerSearchCharacterNameInformation : AbstractPlayerSearchInformation
{

public const short Id = 4980;
public override short TypeId
{
    get { return Id; }
}

public string name;
        

public PlayerSearchCharacterNameInformation()
{
}

public PlayerSearchCharacterNameInformation(string name)
        {
            this.name = name;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            

}


}


}