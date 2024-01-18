


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class DungeonPartyFinderRoomContentUpdateMessage : NetworkMessage
{

public const uint Id = 9135;
public uint MessageId
{
    get { return Id; }
}

public uint dungeonId;
        public Types.DungeonPartyFinderPlayer[] addedPlayers;
        public double[] removedPlayersIds;
        

public DungeonPartyFinderRoomContentUpdateMessage()
{
}

public DungeonPartyFinderRoomContentUpdateMessage(uint dungeonId, Types.DungeonPartyFinderPlayer[] addedPlayers, double[] removedPlayersIds)
        {
            this.dungeonId = dungeonId;
            this.addedPlayers = addedPlayers;
            this.removedPlayersIds = removedPlayersIds;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)dungeonId);
            writer.WriteShort((short)addedPlayers.Length);
            foreach (var entry in addedPlayers)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)removedPlayersIds.Length);
            foreach (var entry in removedPlayersIds)
            {
                 writer.WriteVarLong(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

dungeonId = reader.ReadVarUhShort();
            var limit = (ushort)reader.ReadUShort();
            addedPlayers = new Types.DungeonPartyFinderPlayer[limit];
            for (int i = 0; i < limit; i++)
            {
                 addedPlayers[i] = new Types.DungeonPartyFinderPlayer();
                 addedPlayers[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            removedPlayersIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 removedPlayersIds[i] = reader.ReadVarUhLong();
            }
            

}


}


}