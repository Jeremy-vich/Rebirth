


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class FighterStatsListMessage : NetworkMessage
{

public const uint Id = 9127;
public uint MessageId
{
    get { return Id; }
}

public Types.CharacterCharacteristicsInformations stats;
        

public FighterStatsListMessage()
{
}

public FighterStatsListMessage(Types.CharacterCharacteristicsInformations stats)
        {
            this.stats = stats;
        }
        

public void Serialize(IDataWriter writer)
{

stats.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

stats = new Types.CharacterCharacteristicsInformations();
            stats.Deserialize(reader);
            

}


}


}