


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CharacterExperienceGainMessage : NetworkMessage
{

public const uint Id = 7492;
public uint MessageId
{
    get { return Id; }
}

public double experienceCharacter;
        public double experienceMount;
        public double experienceGuild;
        public double experienceIncarnation;
        

public CharacterExperienceGainMessage()
{
}

public CharacterExperienceGainMessage(double experienceCharacter, double experienceMount, double experienceGuild, double experienceIncarnation)
        {
            this.experienceCharacter = experienceCharacter;
            this.experienceMount = experienceMount;
            this.experienceGuild = experienceGuild;
            this.experienceIncarnation = experienceIncarnation;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(experienceCharacter);
            writer.WriteVarLong(experienceMount);
            writer.WriteVarLong(experienceGuild);
            writer.WriteVarLong(experienceIncarnation);
            

}

public void Deserialize(IDataReader reader)
{

experienceCharacter = reader.ReadVarUhLong();
            experienceMount = reader.ReadVarUhLong();
            experienceGuild = reader.ReadVarUhLong();
            experienceIncarnation = reader.ReadVarUhLong();
            

}


}


}