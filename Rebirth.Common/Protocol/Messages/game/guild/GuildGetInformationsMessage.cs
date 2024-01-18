


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildGetInformationsMessage : NetworkMessage
{

public const uint Id = 9321;
public uint MessageId
{
    get { return Id; }
}

public sbyte infoType;
        

public GuildGetInformationsMessage()
{
}

public GuildGetInformationsMessage(sbyte infoType)
        {
            this.infoType = infoType;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(infoType);
            

}

public void Deserialize(IDataReader reader)
{

infoType = reader.ReadSbyte();
            

}


}


}