


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MapComplementaryInformationsAnomalyMessage : MapComplementaryInformationsDataMessage
{

public const uint Id = 9404;
public uint MessageId
{
    get { return Id; }
}

public uint level;
        public double closingTime;
        

public MapComplementaryInformationsAnomalyMessage()
{
}

public MapComplementaryInformationsAnomalyMessage(uint subAreaId, double mapId, Types.HouseInformations[] houses, Types.GameRolePlayActorInformations[] actors, Types.InteractiveElement[] interactiveElements, Types.StatedElement[] statedElements, Types.MapObstacle[] obstacles, Types.FightCommonInformations[] fights, bool hasAggressiveMonsters, Types.FightStartingPositions fightStartPositions, uint level, double closingTime)
         : base(subAreaId, mapId, houses, actors, interactiveElements, statedElements, obstacles, fights, hasAggressiveMonsters, fightStartPositions)
        {
            this.level = level;
            this.closingTime = closingTime;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)level);
            writer.WriteVarLong(closingTime);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            level = reader.ReadVarUhShort();
            closingTime = reader.ReadVarUhLong();
            

}


}


}