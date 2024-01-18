


















// Generated on 01/30/2023 13:09:18
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PartyJoinMessage : AbstractPartyMessage
{

public const uint Id = 4151;
public uint MessageId
{
    get { return Id; }
}

public sbyte partyType;
        public double partyLeaderId;
        public sbyte maxParticipants;
        public Types.PartyMemberInformations[] members;
        public Types.PartyGuestInformations[] guests;
        public bool restricted;
        public string partyName;
        

public PartyJoinMessage()
{
}

public PartyJoinMessage(uint partyId, sbyte partyType, double partyLeaderId, sbyte maxParticipants, Types.PartyMemberInformations[] members, Types.PartyGuestInformations[] guests, bool restricted, string partyName)
         : base(partyId)
        {
            this.partyType = partyType;
            this.partyLeaderId = partyLeaderId;
            this.maxParticipants = maxParticipants;
            this.members = members;
            this.guests = guests;
            this.restricted = restricted;
            this.partyName = partyName;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(partyType);
            writer.WriteVarLong(partyLeaderId);
            writer.WriteSbyte(maxParticipants);
            writer.WriteShort((short)members.Length);
            foreach (var entry in members)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)guests.Length);
            foreach (var entry in guests)
            {
                 entry.Serialize(writer);
            }
            writer.WriteBoolean(restricted);
            writer.WriteUTF(partyName);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            partyType = reader.ReadSbyte();
            partyLeaderId = reader.ReadVarUhLong();
            maxParticipants = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            members = new Types.PartyMemberInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 members[i] = ProtocolTypeManager.GetInstance<Types.PartyMemberInformations>(reader.ReadUShort());
                 members[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            guests = new Types.PartyGuestInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 guests[i] = new Types.PartyGuestInformations();
                 guests[i].Deserialize(reader);
            }
            restricted = reader.ReadBoolean();
            partyName = reader.ReadUTF();
            

}


}


}