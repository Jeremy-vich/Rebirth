


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class AbstractFightTeamInformations
{

public const short Id = 7551;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte teamId;
        public double leaderId;
        public sbyte teamSide;
        public sbyte teamTypeId;
        public sbyte nbWaves;
        

public AbstractFightTeamInformations()
{
}

public AbstractFightTeamInformations(sbyte teamId, double leaderId, sbyte teamSide, sbyte teamTypeId, sbyte nbWaves)
        {
            this.teamId = teamId;
            this.leaderId = leaderId;
            this.teamSide = teamSide;
            this.teamTypeId = teamTypeId;
            this.nbWaves = nbWaves;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(teamId);
            writer.WriteDouble(leaderId);
            writer.WriteSbyte(teamSide);
            writer.WriteSbyte(teamTypeId);
            writer.WriteSbyte(nbWaves);
            

}

public virtual void Deserialize(IDataReader reader)
{

teamId = reader.ReadSbyte();
            leaderId = reader.ReadDouble();
            teamSide = reader.ReadSbyte();
            teamTypeId = reader.ReadSbyte();
            nbWaves = reader.ReadSbyte();
            

}


}


}