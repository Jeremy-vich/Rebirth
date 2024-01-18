


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightRemoveTeamMemberMessage : NetworkMessage
{

public const uint Id = 5999;
public uint MessageId
{
    get { return Id; }
}

public uint fightId;
        public sbyte teamId;
        public double charId;
        

public GameFightRemoveTeamMemberMessage()
{
}

public GameFightRemoveTeamMemberMessage(uint fightId, sbyte teamId, double charId)
        {
            this.fightId = fightId;
            this.teamId = teamId;
            this.charId = charId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)fightId);
            writer.WriteSbyte(teamId);
            writer.WriteDouble(charId);
            

}

public void Deserialize(IDataReader reader)
{

fightId = reader.ReadVarUhShort();
            teamId = reader.ReadSbyte();
            charId = reader.ReadDouble();
            

}


}


}