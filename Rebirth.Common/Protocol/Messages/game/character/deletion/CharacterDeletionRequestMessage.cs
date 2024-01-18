


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CharacterDeletionRequestMessage : NetworkMessage
{

public const uint Id = 6311;
public uint MessageId
{
    get { return Id; }
}

public double characterId;
        public string secretAnswerHash;
        

public CharacterDeletionRequestMessage()
{
}

public CharacterDeletionRequestMessage(double characterId, string secretAnswerHash)
        {
            this.characterId = characterId;
            this.secretAnswerHash = secretAnswerHash;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(characterId);
            writer.WriteUTF(secretAnswerHash);
            

}

public void Deserialize(IDataReader reader)
{

characterId = reader.ReadVarUhLong();
            secretAnswerHash = reader.ReadUTF();
            

}


}


}