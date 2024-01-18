


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildApplicationIsAnsweredMessage : NetworkMessage
{

public const uint Id = 507;
public uint MessageId
{
    get { return Id; }
}

public bool accepted;
        public Types.GuildInformations guildInformation;
        

public GuildApplicationIsAnsweredMessage()
{
}

public GuildApplicationIsAnsweredMessage(bool accepted, Types.GuildInformations guildInformation)
        {
            this.accepted = accepted;
            this.guildInformation = guildInformation;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(accepted);
            guildInformation.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

accepted = reader.ReadBoolean();
            guildInformation = new Types.GuildInformations();
            guildInformation.Deserialize(reader);
            

}


}


}