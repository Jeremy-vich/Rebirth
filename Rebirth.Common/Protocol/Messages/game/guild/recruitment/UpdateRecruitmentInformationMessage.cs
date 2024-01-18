


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class UpdateRecruitmentInformationMessage : NetworkMessage
{

public const uint Id = 9009;
public uint MessageId
{
    get { return Id; }
}

public Types.GuildRecruitmentInformation recruitmentData;
        

public UpdateRecruitmentInformationMessage()
{
}

public UpdateRecruitmentInformationMessage(Types.GuildRecruitmentInformation recruitmentData)
        {
            this.recruitmentData = recruitmentData;
        }
        

public void Serialize(IDataWriter writer)
{

recruitmentData.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

recruitmentData = new Types.GuildRecruitmentInformation();
            recruitmentData.Deserialize(reader);
            

}


}


}