


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildChestTabContributionsMessage : NetworkMessage
{

public const uint Id = 6766;
public uint MessageId
{
    get { return Id; }
}

public Types.Contribution[] contributions;
        

public GuildChestTabContributionsMessage()
{
}

public GuildChestTabContributionsMessage(Types.Contribution[] contributions)
        {
            this.contributions = contributions;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)contributions.Length);
            foreach (var entry in contributions)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            contributions = new Types.Contribution[limit];
            for (int i = 0; i < limit; i++)
            {
                 contributions[i] = new Types.Contribution();
                 contributions[i].Deserialize(reader);
            }
            

}


}


}