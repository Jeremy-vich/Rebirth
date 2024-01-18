


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ChallengeInfoMessage : NetworkMessage
{

public const uint Id = 3253;
public uint MessageId
{
    get { return Id; }
}

public uint challengeId;
        public double targetId;
        public uint xpBonus;
        public uint dropBonus;
        

public ChallengeInfoMessage()
{
}

public ChallengeInfoMessage(uint challengeId, double targetId, uint xpBonus, uint dropBonus)
        {
            this.challengeId = challengeId;
            this.targetId = targetId;
            this.xpBonus = xpBonus;
            this.dropBonus = dropBonus;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)challengeId);
            writer.WriteDouble(targetId);
            writer.WriteVarInt((int)xpBonus);
            writer.WriteVarInt((int)dropBonus);
            

}

public void Deserialize(IDataReader reader)
{

challengeId = reader.ReadVarUhShort();
            targetId = reader.ReadDouble();
            xpBonus = reader.ReadVarUhInt();
            dropBonus = reader.ReadVarUhInt();
            

}


}


}