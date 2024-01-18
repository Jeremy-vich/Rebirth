


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildLogbookInformationMessage : NetworkMessage
{

public const uint Id = 1301;
public uint MessageId
{
    get { return Id; }
}

public Types.GuildLogbookEntryBasicInformation[] globalActivities;
        public Types.GuildLogbookEntryBasicInformation[] chestActivities;
        

public GuildLogbookInformationMessage()
{
}

public GuildLogbookInformationMessage(Types.GuildLogbookEntryBasicInformation[] globalActivities, Types.GuildLogbookEntryBasicInformation[] chestActivities)
        {
            this.globalActivities = globalActivities;
            this.chestActivities = chestActivities;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)globalActivities.Length);
            foreach (var entry in globalActivities)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)chestActivities.Length);
            foreach (var entry in chestActivities)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            globalActivities = new Types.GuildLogbookEntryBasicInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 globalActivities[i] = ProtocolTypeManager.GetInstance<Types.GuildLogbookEntryBasicInformation>(reader.ReadUShort());
                 globalActivities[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            chestActivities = new Types.GuildLogbookEntryBasicInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 chestActivities[i] = ProtocolTypeManager.GetInstance<Types.GuildLogbookEntryBasicInformation>(reader.ReadUShort());
                 chestActivities[i].Deserialize(reader);
            }
            

}


}


}