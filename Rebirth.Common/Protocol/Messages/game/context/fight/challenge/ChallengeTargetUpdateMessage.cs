


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ChallengeTargetUpdateMessage : NetworkMessage
{

public const uint Id = 6811;
public uint MessageId
{
    get { return Id; }
}

public uint challengeId;
        public double targetId;
        

public ChallengeTargetUpdateMessage()
{
}

public ChallengeTargetUpdateMessage(uint challengeId, double targetId)
        {
            this.challengeId = challengeId;
            this.targetId = targetId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)challengeId);
            writer.WriteDouble(targetId);
            

}

public void Deserialize(IDataReader reader)
{

challengeId = reader.ReadVarUhShort();
            targetId = reader.ReadDouble();
            

}


}


}