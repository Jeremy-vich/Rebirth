


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildLevelUpMessage : NetworkMessage
{

public const uint Id = 3746;
public uint MessageId
{
    get { return Id; }
}

public byte newLevel;
        

public GuildLevelUpMessage()
{
}

public GuildLevelUpMessage(byte newLevel)
        {
            this.newLevel = newLevel;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteByte(newLevel);
            

}

public void Deserialize(IDataReader reader)
{

newLevel = reader.ReadByte();
            

}


}


}