


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ChallengeTargetsListRequestMessage : NetworkMessage
{

public const uint Id = 2836;
public uint MessageId
{
    get { return Id; }
}

public uint challengeId;
        

public ChallengeTargetsListRequestMessage()
{
}

public ChallengeTargetsListRequestMessage(uint challengeId)
        {
            this.challengeId = challengeId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)challengeId);
            

}

public void Deserialize(IDataReader reader)
{

challengeId = reader.ReadVarUhShort();
            

}


}


}