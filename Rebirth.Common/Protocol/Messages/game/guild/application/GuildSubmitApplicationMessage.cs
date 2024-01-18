


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildSubmitApplicationMessage : NetworkMessage
{

public const uint Id = 190;
public uint MessageId
{
    get { return Id; }
}

public string applyText;
        public uint guildId;
        public uint timeSpent;
        public string filterLanguage;
        public string filterAmbiance;
        public string filterPlaytime;
        public string filterInterest;
        public string filterMinMaxGuildLevel;
        public string filterRecruitmentType;
        public string filterMinMaxCharacterLevel;
        public string filterMinMaxAchievement;
        public string filterSearchName;
        public string filterLastSort;
        

public GuildSubmitApplicationMessage()
{
}

public GuildSubmitApplicationMessage(string applyText, uint guildId, uint timeSpent, string filterLanguage, string filterAmbiance, string filterPlaytime, string filterInterest, string filterMinMaxGuildLevel, string filterRecruitmentType, string filterMinMaxCharacterLevel, string filterMinMaxAchievement, string filterSearchName, string filterLastSort)
        {
            this.applyText = applyText;
            this.guildId = guildId;
            this.timeSpent = timeSpent;
            this.filterLanguage = filterLanguage;
            this.filterAmbiance = filterAmbiance;
            this.filterPlaytime = filterPlaytime;
            this.filterInterest = filterInterest;
            this.filterMinMaxGuildLevel = filterMinMaxGuildLevel;
            this.filterRecruitmentType = filterRecruitmentType;
            this.filterMinMaxCharacterLevel = filterMinMaxCharacterLevel;
            this.filterMinMaxAchievement = filterMinMaxAchievement;
            this.filterSearchName = filterSearchName;
            this.filterLastSort = filterLastSort;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(applyText);
            writer.WriteVarInt((int)guildId);
            writer.WriteVarInt((int)timeSpent);
            writer.WriteUTF(filterLanguage);
            writer.WriteUTF(filterAmbiance);
            writer.WriteUTF(filterPlaytime);
            writer.WriteUTF(filterInterest);
            writer.WriteUTF(filterMinMaxGuildLevel);
            writer.WriteUTF(filterRecruitmentType);
            writer.WriteUTF(filterMinMaxCharacterLevel);
            writer.WriteUTF(filterMinMaxAchievement);
            writer.WriteUTF(filterSearchName);
            writer.WriteUTF(filterLastSort);
            

}

public void Deserialize(IDataReader reader)
{

applyText = reader.ReadUTF();
            guildId = reader.ReadVarUhInt();
            timeSpent = reader.ReadVarUhInt();
            filterLanguage = reader.ReadUTF();
            filterAmbiance = reader.ReadUTF();
            filterPlaytime = reader.ReadUTF();
            filterInterest = reader.ReadUTF();
            filterMinMaxGuildLevel = reader.ReadUTF();
            filterRecruitmentType = reader.ReadUTF();
            filterMinMaxCharacterLevel = reader.ReadUTF();
            filterMinMaxAchievement = reader.ReadUTF();
            filterSearchName = reader.ReadUTF();
            filterLastSort = reader.ReadUTF();
            

}


}


}