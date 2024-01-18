


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MapFightStartPositionsUpdateMessage : NetworkMessage
{

public const uint Id = 8655;
public uint MessageId
{
    get { return Id; }
}

public double mapId;
        public Types.FightStartingPositions fightStartPositions;
        

public MapFightStartPositionsUpdateMessage()
{
}

public MapFightStartPositionsUpdateMessage(double mapId, Types.FightStartingPositions fightStartPositions)
        {
            this.mapId = mapId;
            this.fightStartPositions = fightStartPositions;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(mapId);
            fightStartPositions.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

mapId = reader.ReadDouble();
            fightStartPositions = new Types.FightStartingPositions();
            fightStartPositions.Deserialize(reader);
            

}


}


}