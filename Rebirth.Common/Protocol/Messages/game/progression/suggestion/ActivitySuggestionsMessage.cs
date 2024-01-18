


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ActivitySuggestionsMessage : NetworkMessage
{

public const uint Id = 2157;
public uint MessageId
{
    get { return Id; }
}

public uint[] lockedActivitiesIds;
        public uint[] unlockedActivitiesIds;
        

public ActivitySuggestionsMessage()
{
}

public ActivitySuggestionsMessage(uint[] lockedActivitiesIds, uint[] unlockedActivitiesIds)
        {
            this.lockedActivitiesIds = lockedActivitiesIds;
            this.unlockedActivitiesIds = unlockedActivitiesIds;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)lockedActivitiesIds.Length);
            foreach (var entry in lockedActivitiesIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)unlockedActivitiesIds.Length);
            foreach (var entry in unlockedActivitiesIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            lockedActivitiesIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 lockedActivitiesIds[i] = reader.ReadVarUhShort();
            }
            limit = (ushort)reader.ReadUShort();
            unlockedActivitiesIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 unlockedActivitiesIds[i] = reader.ReadVarUhShort();
            }
            

}


}


}