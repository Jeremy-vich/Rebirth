


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CharacterLevelUpInformationMessage : CharacterLevelUpMessage
{

public const uint Id = 5824;
public uint MessageId
{
    get { return Id; }
}

public string name;
        public double id;
        

public CharacterLevelUpInformationMessage()
{
}

public CharacterLevelUpInformationMessage(uint newLevel, string name, double id)
         : base(newLevel)
        {
            this.name = name;
            this.id = id;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteVarLong(id);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            id = reader.ReadVarUhLong();
            

}


}


}