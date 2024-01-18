


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AbstractPartyMemberInFightMessage : AbstractPartyMessage
{

public const uint Id = 7461;
public uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        public double memberId;
        public int memberAccountId;
        public string memberName;
        public uint fightId;
        public int timeBeforeFightStart;
        

public AbstractPartyMemberInFightMessage()
{
}

public AbstractPartyMemberInFightMessage(uint partyId, sbyte reason, double memberId, int memberAccountId, string memberName, uint fightId, int timeBeforeFightStart)
         : base(partyId)
        {
            this.reason = reason;
            this.memberId = memberId;
            this.memberAccountId = memberAccountId;
            this.memberName = memberName;
            this.fightId = fightId;
            this.timeBeforeFightStart = timeBeforeFightStart;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(reason);
            writer.WriteVarLong(memberId);
            writer.WriteInt(memberAccountId);
            writer.WriteUTF(memberName);
            writer.WriteVarShort((int)fightId);
            writer.WriteVarShort((int)timeBeforeFightStart);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            reason = reader.ReadSbyte();
            memberId = reader.ReadVarUhLong();
            memberAccountId = reader.ReadInt();
            memberName = reader.ReadUTF();
            fightId = reader.ReadVarUhShort();
            timeBeforeFightStart = reader.ReadVarShort();
            

}


}


}