


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MapComplementaryInformationsWithCoordsMessage : MapComplementaryInformationsDataMessage
{

public const uint Id = 8805;
public uint MessageId
{
    get { return Id; }
}

public short worldX;
        public short worldY;
        

public MapComplementaryInformationsWithCoordsMessage()
{
}

public MapComplementaryInformationsWithCoordsMessage(uint subAreaId, double mapId, Types.HouseInformations[] houses, Types.GameRolePlayActorInformations[] actors, Types.InteractiveElement[] interactiveElements, Types.StatedElement[] statedElements, Types.MapObstacle[] obstacles, Types.FightCommonInformations[] fights, bool hasAggressiveMonsters, Types.FightStartingPositions fightStartPositions, short worldX, short worldY)
         : base(subAreaId, mapId, houses, actors, interactiveElements, statedElements, obstacles, fights, hasAggressiveMonsters, fightStartPositions)
        {
            this.worldX = worldX;
            this.worldY = worldY;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            

}


}


}