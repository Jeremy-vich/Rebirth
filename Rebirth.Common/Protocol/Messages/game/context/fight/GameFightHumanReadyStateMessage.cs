


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightHumanReadyStateMessage : NetworkMessage
{

public const uint Id = 6173;
public uint MessageId
{
    get { return Id; }
}

public double characterId;
        public bool isReady;
        

public GameFightHumanReadyStateMessage()
{
}

public GameFightHumanReadyStateMessage(double characterId, bool isReady)
        {
            this.characterId = characterId;
            this.isReady = isReady;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(characterId);
            writer.WriteBoolean(isReady);
            

}

public void Deserialize(IDataReader reader)
{

characterId = reader.ReadVarUhLong();
            isReady = reader.ReadBoolean();
            

}


}


}