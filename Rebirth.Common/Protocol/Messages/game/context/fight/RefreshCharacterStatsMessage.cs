


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class RefreshCharacterStatsMessage : NetworkMessage
{

public const uint Id = 3301;
public uint MessageId
{
    get { return Id; }
}

public double fighterId;
        public Types.GameFightCharacteristics stats;
        

public RefreshCharacterStatsMessage()
{
}

public RefreshCharacterStatsMessage(double fighterId, Types.GameFightCharacteristics stats)
        {
            this.fighterId = fighterId;
            this.stats = stats;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(fighterId);
            stats.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

fighterId = reader.ReadDouble();
            stats = new Types.GameFightCharacteristics();
            stats.Deserialize(reader);
            

}


}


}