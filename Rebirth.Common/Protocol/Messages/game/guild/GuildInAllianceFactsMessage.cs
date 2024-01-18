


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildInAllianceFactsMessage : GuildFactsMessage
{

public const uint Id = 4511;
public uint MessageId
{
    get { return Id; }
}

public Types.BasicNamedAllianceInformations allianceInfos;
        

public GuildInAllianceFactsMessage()
{
}

public GuildInAllianceFactsMessage(Types.GuildFactSheetInformations infos, int creationDate, uint nbTaxCollectors, Types.CharacterMinimalGuildPublicInformations[] members, Types.BasicNamedAllianceInformations allianceInfos)
         : base(infos, creationDate, nbTaxCollectors, members)
        {
            this.allianceInfos = allianceInfos;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            allianceInfos.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            allianceInfos = new Types.BasicNamedAllianceInformations();
            allianceInfos.Deserialize(reader);
            

}


}


}