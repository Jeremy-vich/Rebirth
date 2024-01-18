


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildUpdateNoteMessage : NetworkMessage
{

public const uint Id = 3003;
public uint MessageId
{
    get { return Id; }
}

public double memberId;
        public string note;
        

public GuildUpdateNoteMessage()
{
}

public GuildUpdateNoteMessage(double memberId, string note)
        {
            this.memberId = memberId;
            this.note = note;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(memberId);
            writer.WriteUTF(note);
            

}

public void Deserialize(IDataReader reader)
{

memberId = reader.ReadVarUhLong();
            note = reader.ReadUTF();
            

}


}


}