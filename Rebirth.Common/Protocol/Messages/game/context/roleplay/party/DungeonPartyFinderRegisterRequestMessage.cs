


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class DungeonPartyFinderRegisterRequestMessage : NetworkMessage
{

public const uint Id = 1894;
public uint MessageId
{
    get { return Id; }
}

public uint[] dungeonIds;
        

public DungeonPartyFinderRegisterRequestMessage()
{
}

public DungeonPartyFinderRegisterRequestMessage(uint[] dungeonIds)
        {
            this.dungeonIds = dungeonIds;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)dungeonIds.Length);
            foreach (var entry in dungeonIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            dungeonIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 dungeonIds[i] = reader.ReadVarUhShort();
            }
            

}


}


}