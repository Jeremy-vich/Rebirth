


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayArenaFightAnswerMessage : NetworkMessage
{

public const uint Id = 3402;
public uint MessageId
{
    get { return Id; }
}

public uint fightId;
        public bool accept;
        

public GameRolePlayArenaFightAnswerMessage()
{
}

public GameRolePlayArenaFightAnswerMessage(uint fightId, bool accept)
        {
            this.fightId = fightId;
            this.accept = accept;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)fightId);
            writer.WriteBoolean(accept);
            

}

public void Deserialize(IDataReader reader)
{

fightId = reader.ReadVarUhShort();
            accept = reader.ReadBoolean();
            

}


}


}