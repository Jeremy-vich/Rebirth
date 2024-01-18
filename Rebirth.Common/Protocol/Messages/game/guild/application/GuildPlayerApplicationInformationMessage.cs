


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildPlayerApplicationInformationMessage : GuildPlayerApplicationAbstractMessage
{

public const uint Id = 7125;
public uint MessageId
{
    get { return Id; }
}

public Types.GuildInformations guildInformation;
        public Types.GuildApplicationInformation apply;
        

public GuildPlayerApplicationInformationMessage()
{
}

public GuildPlayerApplicationInformationMessage(Types.GuildInformations guildInformation, Types.GuildApplicationInformation apply)
        {
            this.guildInformation = guildInformation;
            this.apply = apply;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            guildInformation.Serialize(writer);
            apply.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            guildInformation = new Types.GuildInformations();
            guildInformation.Deserialize(reader);
            apply = new Types.GuildApplicationInformation();
            apply.Deserialize(reader);
            

}


}


}