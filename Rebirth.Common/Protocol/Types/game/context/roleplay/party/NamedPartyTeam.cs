


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class NamedPartyTeam
{

public const short Id = 1488;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte teamId;
        public string partyName;
        

public NamedPartyTeam()
{
}

public NamedPartyTeam(sbyte teamId, string partyName)
        {
            this.teamId = teamId;
            this.partyName = partyName;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(teamId);
            writer.WriteUTF(partyName);
            

}

public virtual void Deserialize(IDataReader reader)
{

teamId = reader.ReadSbyte();
            partyName = reader.ReadUTF();
            

}


}


}