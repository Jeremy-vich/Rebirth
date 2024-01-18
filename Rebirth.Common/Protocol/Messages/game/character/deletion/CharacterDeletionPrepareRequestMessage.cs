


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CharacterDeletionPrepareRequestMessage : NetworkMessage
{

public const uint Id = 2431;
public uint MessageId
{
    get { return Id; }
}

public double characterId;
        

public CharacterDeletionPrepareRequestMessage()
{
}

public CharacterDeletionPrepareRequestMessage(double characterId)
        {
            this.characterId = characterId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(characterId);
            

}

public void Deserialize(IDataReader reader)
{

characterId = reader.ReadVarUhLong();
            

}


}


}