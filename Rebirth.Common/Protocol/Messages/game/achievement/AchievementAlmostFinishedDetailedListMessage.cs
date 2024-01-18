


















// Generated on 01/30/2023 13:09:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AchievementAlmostFinishedDetailedListMessage : NetworkMessage
{

public const uint Id = 2807;
public uint MessageId
{
    get { return Id; }
}

public Types.Achievement[] almostFinishedAchievements;
        

public AchievementAlmostFinishedDetailedListMessage()
{
}

public AchievementAlmostFinishedDetailedListMessage(Types.Achievement[] almostFinishedAchievements)
        {
            this.almostFinishedAchievements = almostFinishedAchievements;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)almostFinishedAchievements.Length);
            foreach (var entry in almostFinishedAchievements)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            almostFinishedAchievements = new Types.Achievement[limit];
            for (int i = 0; i < limit; i++)
            {
                 almostFinishedAchievements[i] = new Types.Achievement();
                 almostFinishedAchievements[i].Deserialize(reader);
            }
            

}


}


}