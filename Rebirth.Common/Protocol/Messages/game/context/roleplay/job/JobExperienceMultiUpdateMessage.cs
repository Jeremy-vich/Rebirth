


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class JobExperienceMultiUpdateMessage : NetworkMessage
{

public const uint Id = 7925;
public uint MessageId
{
    get { return Id; }
}

public Types.JobExperience[] experiencesUpdate;
        

public JobExperienceMultiUpdateMessage()
{
}

public JobExperienceMultiUpdateMessage(Types.JobExperience[] experiencesUpdate)
        {
            this.experiencesUpdate = experiencesUpdate;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)experiencesUpdate.Length);
            foreach (var entry in experiencesUpdate)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            experiencesUpdate = new Types.JobExperience[limit];
            for (int i = 0; i < limit; i++)
            {
                 experiencesUpdate[i] = new Types.JobExperience();
                 experiencesUpdate[i].Deserialize(reader);
            }
            

}


}


}