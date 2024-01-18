


















// Generated on 01/30/2023 13:09:18
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PartyInvitationMessage : AbstractPartyMessage
{

public const uint Id = 3195;
public uint MessageId
{
    get { return Id; }
}

public sbyte partyType;
        public string partyName;
        public sbyte maxParticipants;
        public double fromId;
        public string fromName;
        public double toId;
        

public PartyInvitationMessage()
{
}

public PartyInvitationMessage(uint partyId, sbyte partyType, string partyName, sbyte maxParticipants, double fromId, string fromName, double toId)
         : base(partyId)
        {
            this.partyType = partyType;
            this.partyName = partyName;
            this.maxParticipants = maxParticipants;
            this.fromId = fromId;
            this.fromName = fromName;
            this.toId = toId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(partyType);
            writer.WriteUTF(partyName);
            writer.WriteSbyte(maxParticipants);
            writer.WriteVarLong(fromId);
            writer.WriteUTF(fromName);
            writer.WriteVarLong(toId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            partyType = reader.ReadSbyte();
            partyName = reader.ReadUTF();
            maxParticipants = reader.ReadSbyte();
            fromId = reader.ReadVarUhLong();
            fromName = reader.ReadUTF();
            toId = reader.ReadVarUhLong();
            

}


}


}