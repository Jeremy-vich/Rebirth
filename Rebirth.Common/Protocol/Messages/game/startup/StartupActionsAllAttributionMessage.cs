


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class StartupActionsAllAttributionMessage : NetworkMessage
{

public const uint Id = 5005;
public uint MessageId
{
    get { return Id; }
}

public double characterId;
        

public StartupActionsAllAttributionMessage()
{
}

public StartupActionsAllAttributionMessage(double characterId)
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