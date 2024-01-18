


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildApplicationListenMessage : NetworkMessage
{

public const uint Id = 6713;
public uint MessageId
{
    get { return Id; }
}

public bool listen;
        

public GuildApplicationListenMessage()
{
}

public GuildApplicationListenMessage(bool listen)
        {
            this.listen = listen;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(listen);
            

}

public void Deserialize(IDataReader reader)
{

listen = reader.ReadBoolean();
            

}


}


}