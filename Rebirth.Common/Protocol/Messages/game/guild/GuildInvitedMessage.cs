


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildInvitedMessage : NetworkMessage
{

public const uint Id = 2525;
public uint MessageId
{
    get { return Id; }
}

public double recruterId;
        public string recruterName;
        public Types.GuildInformations guildInfo;
        

public GuildInvitedMessage()
{
}

public GuildInvitedMessage(double recruterId, string recruterName, Types.GuildInformations guildInfo)
        {
            this.recruterId = recruterId;
            this.recruterName = recruterName;
            this.guildInfo = guildInfo;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(recruterId);
            writer.WriteUTF(recruterName);
            guildInfo.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

recruterId = reader.ReadVarUhLong();
            recruterName = reader.ReadUTF();
            guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
            

}


}


}