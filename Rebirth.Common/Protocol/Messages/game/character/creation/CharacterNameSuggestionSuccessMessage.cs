


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CharacterNameSuggestionSuccessMessage : NetworkMessage
{

public const uint Id = 5468;
public uint MessageId
{
    get { return Id; }
}

public string suggestion;
        

public CharacterNameSuggestionSuccessMessage()
{
}

public CharacterNameSuggestionSuccessMessage(string suggestion)
        {
            this.suggestion = suggestion;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(suggestion);
            

}

public void Deserialize(IDataReader reader)
{

suggestion = reader.ReadUTF();
            

}


}


}