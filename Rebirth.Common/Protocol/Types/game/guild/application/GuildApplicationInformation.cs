


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GuildApplicationInformation
{

public const short Id = 8441;
public virtual short TypeId
{
    get { return Id; }
}

public Types.ApplicationPlayerInformation playerInfo;
        public string applyText;
        public double creationDate;
        

public GuildApplicationInformation()
{
}

public GuildApplicationInformation(Types.ApplicationPlayerInformation playerInfo, string applyText, double creationDate)
        {
            this.playerInfo = playerInfo;
            this.applyText = applyText;
            this.creationDate = creationDate;
        }
        

public virtual void Serialize(IDataWriter writer)
{

playerInfo.Serialize(writer);
            writer.WriteUTF(applyText);
            writer.WriteDouble(creationDate);
            

}

public virtual void Deserialize(IDataReader reader)
{

playerInfo = new Types.ApplicationPlayerInformation();
            playerInfo.Deserialize(reader);
            applyText = reader.ReadUTF();
            creationDate = reader.ReadDouble();
            

}


}


}