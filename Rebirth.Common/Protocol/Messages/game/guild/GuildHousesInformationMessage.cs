


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildHousesInformationMessage : NetworkMessage
{

public const uint Id = 2521;
public uint MessageId
{
    get { return Id; }
}

public Types.HouseInformationsForGuild[] housesInformations;
        

public GuildHousesInformationMessage()
{
}

public GuildHousesInformationMessage(Types.HouseInformationsForGuild[] housesInformations)
        {
            this.housesInformations = housesInformations;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)housesInformations.Length);
            foreach (var entry in housesInformations)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            housesInformations = new Types.HouseInformationsForGuild[limit];
            for (int i = 0; i < limit; i++)
            {
                 housesInformations[i] = new Types.HouseInformationsForGuild();
                 housesInformations[i].Deserialize(reader);
            }
            

}


}


}