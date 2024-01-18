


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildChestTabLastContributionMessage : NetworkMessage
{

public const uint Id = 2135;
public uint MessageId
{
    get { return Id; }
}

public double lastContributionDate;
        

public GuildChestTabLastContributionMessage()
{
}

public GuildChestTabLastContributionMessage(double lastContributionDate)
        {
            this.lastContributionDate = lastContributionDate;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(lastContributionDate);
            

}

public void Deserialize(IDataReader reader)
{

lastContributionDate = reader.ReadDouble();
            

}


}


}