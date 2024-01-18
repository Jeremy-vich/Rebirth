


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightNewWaveMessage : NetworkMessage
{

public const uint Id = 1173;
public uint MessageId
{
    get { return Id; }
}

public sbyte id;
        public sbyte teamId;
        public short nbTurnBeforeNextWave;
        

public GameFightNewWaveMessage()
{
}

public GameFightNewWaveMessage(sbyte id, sbyte teamId, short nbTurnBeforeNextWave)
        {
            this.id = id;
            this.teamId = teamId;
            this.nbTurnBeforeNextWave = nbTurnBeforeNextWave;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(id);
            writer.WriteSbyte(teamId);
            writer.WriteShort(nbTurnBeforeNextWave);
            

}

public void Deserialize(IDataReader reader)
{

id = reader.ReadSbyte();
            teamId = reader.ReadSbyte();
            nbTurnBeforeNextWave = reader.ReadShort();
            

}


}


}