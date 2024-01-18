


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MapComplementaryInformationsDataInHavenBagMessage : MapComplementaryInformationsDataMessage
{

public const uint Id = 5052;
public uint MessageId
{
    get { return Id; }
}

public Types.CharacterMinimalInformations ownerInformations;
        public sbyte theme;
        public sbyte roomId;
        public sbyte maxRoomId;
        

public MapComplementaryInformationsDataInHavenBagMessage()
{
}

public MapComplementaryInformationsDataInHavenBagMessage(uint subAreaId, double mapId, Types.HouseInformations[] houses, Types.GameRolePlayActorInformations[] actors, Types.InteractiveElement[] interactiveElements, Types.StatedElement[] statedElements, Types.MapObstacle[] obstacles, Types.FightCommonInformations[] fights, bool hasAggressiveMonsters, Types.FightStartingPositions fightStartPositions, Types.CharacterMinimalInformations ownerInformations, sbyte theme, sbyte roomId, sbyte maxRoomId)
         : base(subAreaId, mapId, houses, actors, interactiveElements, statedElements, obstacles, fights, hasAggressiveMonsters, fightStartPositions)
        {
            this.ownerInformations = ownerInformations;
            this.theme = theme;
            this.roomId = roomId;
            this.maxRoomId = maxRoomId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            ownerInformations.Serialize(writer);
            writer.WriteSbyte(theme);
            writer.WriteSbyte(roomId);
            writer.WriteSbyte(maxRoomId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            ownerInformations = new Types.CharacterMinimalInformations();
            ownerInformations.Deserialize(reader);
            theme = reader.ReadSbyte();
            roomId = reader.ReadSbyte();
            maxRoomId = reader.ReadSbyte();
            

}


}


}