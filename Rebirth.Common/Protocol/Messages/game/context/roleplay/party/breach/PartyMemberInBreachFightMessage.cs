


















// Generated on 01/30/2023 13:09:19
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PartyMemberInBreachFightMessage : AbstractPartyMemberInFightMessage
{

public const uint Id = 4813;
public uint MessageId
{
    get { return Id; }
}

public uint floor;
        public sbyte room;
        

public PartyMemberInBreachFightMessage()
{
}

public PartyMemberInBreachFightMessage(uint partyId, sbyte reason, double memberId, int memberAccountId, string memberName, uint fightId, int timeBeforeFightStart, uint floor, sbyte room)
         : base(partyId, reason, memberId, memberAccountId, memberName, fightId, timeBeforeFightStart)
        {
            this.floor = floor;
            this.room = room;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)floor);
            writer.WriteSbyte(room);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            floor = reader.ReadVarUhInt();
            room = reader.ReadSbyte();
            

}


}


}