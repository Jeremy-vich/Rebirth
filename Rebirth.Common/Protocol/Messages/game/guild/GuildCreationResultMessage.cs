


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildCreationResultMessage : NetworkMessage
{

public const uint Id = 1099;
public uint MessageId
{
    get { return Id; }
}

public sbyte result;
        

public GuildCreationResultMessage()
{
}

public GuildCreationResultMessage(sbyte result)
        {
            this.result = result;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(result);
            

}

public void Deserialize(IDataReader reader)
{

result = reader.ReadSbyte();
            

}


}


}