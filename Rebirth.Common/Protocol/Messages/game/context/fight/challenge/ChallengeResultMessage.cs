


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ChallengeResultMessage : NetworkMessage
{

public const uint Id = 8340;
public uint MessageId
{
    get { return Id; }
}

public uint challengeId;
        public bool success;
        

public ChallengeResultMessage()
{
}

public ChallengeResultMessage(uint challengeId, bool success)
        {
            this.challengeId = challengeId;
            this.success = success;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)challengeId);
            writer.WriteBoolean(success);
            

}

public void Deserialize(IDataReader reader)
{

challengeId = reader.ReadVarUhShort();
            success = reader.ReadBoolean();
            

}


}


}