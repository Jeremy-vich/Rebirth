


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CharacterDeletionPrepareMessage : NetworkMessage
{

public const uint Id = 9781;
public uint MessageId
{
    get { return Id; }
}

public double characterId;
        public string characterName;
        public string secretQuestion;
        public bool needSecretAnswer;
        

public CharacterDeletionPrepareMessage()
{
}

public CharacterDeletionPrepareMessage(double characterId, string characterName, string secretQuestion, bool needSecretAnswer)
        {
            this.characterId = characterId;
            this.characterName = characterName;
            this.secretQuestion = secretQuestion;
            this.needSecretAnswer = needSecretAnswer;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(characterId);
            writer.WriteUTF(characterName);
            writer.WriteUTF(secretQuestion);
            writer.WriteBoolean(needSecretAnswer);
            

}

public void Deserialize(IDataReader reader)
{

characterId = reader.ReadVarUhLong();
            characterName = reader.ReadUTF();
            secretQuestion = reader.ReadUTF();
            needSecretAnswer = reader.ReadBoolean();
            

}


}


}