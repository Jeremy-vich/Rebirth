


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class JobExperienceOtherPlayerUpdateMessage : JobExperienceUpdateMessage
{

public const uint Id = 3658;
public uint MessageId
{
    get { return Id; }
}

public double playerId;
        

public JobExperienceOtherPlayerUpdateMessage()
{
}

public JobExperienceOtherPlayerUpdateMessage(Types.JobExperience experiencesUpdate, double playerId)
         : base(experiencesUpdate)
        {
            this.playerId = playerId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(playerId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            

}


}


}