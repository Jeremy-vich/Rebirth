


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildApplicationDeletedMessage : NetworkMessage
{

public const uint Id = 2223;
public uint MessageId
{
    get { return Id; }
}

public bool deleted;
        

public GuildApplicationDeletedMessage()
{
}

public GuildApplicationDeletedMessage(bool deleted)
        {
            this.deleted = deleted;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(deleted);
            

}

public void Deserialize(IDataReader reader)
{

deleted = reader.ReadBoolean();
            

}


}


}