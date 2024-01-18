


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class StartupActionsObjetAttributionMessage : NetworkMessage
{

public const uint Id = 2128;
public uint MessageId
{
    get { return Id; }
}

public int actionId;
        public double characterId;
        

public StartupActionsObjetAttributionMessage()
{
}

public StartupActionsObjetAttributionMessage(int actionId, double characterId)
        {
            this.actionId = actionId;
            this.characterId = characterId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(actionId);
            writer.WriteVarLong(characterId);
            

}

public void Deserialize(IDataReader reader)
{

actionId = reader.ReadInt();
            characterId = reader.ReadVarUhLong();
            

}


}


}