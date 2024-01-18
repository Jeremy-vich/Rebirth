


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildChangeMemberParametersMessage : NetworkMessage
{

public const uint Id = 8129;
public uint MessageId
{
    get { return Id; }
}

public double memberId;
        public uint rankId;
        public sbyte experienceGivenPercent;
        

public GuildChangeMemberParametersMessage()
{
}

public GuildChangeMemberParametersMessage(double memberId, uint rankId, sbyte experienceGivenPercent)
        {
            this.memberId = memberId;
            this.rankId = rankId;
            this.experienceGivenPercent = experienceGivenPercent;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(memberId);
            writer.WriteVarInt((int)rankId);
            writer.WriteSbyte(experienceGivenPercent);
            

}

public void Deserialize(IDataReader reader)
{

memberId = reader.ReadVarUhLong();
            rankId = reader.ReadVarUhInt();
            experienceGivenPercent = reader.ReadSbyte();
            

}


}


}