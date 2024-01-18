


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class AllianceFactSheetInformations : AllianceInformations
{

public const short Id = 3583;
public override short TypeId
{
    get { return Id; }
}

public int creationDate;
        public uint nbGuilds;
        public uint nbMembers;
        public uint nbSubarea;
        

public AllianceFactSheetInformations()
{
}

public AllianceFactSheetInformations(uint allianceId, string allianceTag, string allianceName, Types.GuildEmblem allianceEmblem, int creationDate, uint nbGuilds, uint nbMembers, uint nbSubarea)
         : base(allianceId, allianceTag, allianceName, allianceEmblem)
        {
            this.creationDate = creationDate;
            this.nbGuilds = nbGuilds;
            this.nbMembers = nbMembers;
            this.nbSubarea = nbSubarea;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(creationDate);
            writer.WriteVarShort((int)nbGuilds);
            writer.WriteVarShort((int)nbMembers);
            writer.WriteVarShort((int)nbSubarea);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            creationDate = reader.ReadInt();
            nbGuilds = reader.ReadVarUhShort();
            nbMembers = reader.ReadVarUhShort();
            nbSubarea = reader.ReadVarUhShort();
            

}


}


}