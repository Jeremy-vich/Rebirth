


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildCharacsUpgradeRequestMessage : NetworkMessage
{

public const uint Id = 3359;
public uint MessageId
{
    get { return Id; }
}

public sbyte charaTypeTarget;
        

public GuildCharacsUpgradeRequestMessage()
{
}

public GuildCharacsUpgradeRequestMessage(sbyte charaTypeTarget)
        {
            this.charaTypeTarget = charaTypeTarget;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(charaTypeTarget);
            

}

public void Deserialize(IDataReader reader)
{

charaTypeTarget = reader.ReadSbyte();
            

}


}


}