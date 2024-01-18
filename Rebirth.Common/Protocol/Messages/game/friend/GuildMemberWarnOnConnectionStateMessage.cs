


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildMemberWarnOnConnectionStateMessage : NetworkMessage
{

public const uint Id = 7703;
public uint MessageId
{
    get { return Id; }
}

public bool enable;
        

public GuildMemberWarnOnConnectionStateMessage()
{
}

public GuildMemberWarnOnConnectionStateMessage(bool enable)
        {
            this.enable = enable;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(enable);
            

}

public void Deserialize(IDataReader reader)
{

enable = reader.ReadBoolean();
            

}


}


}