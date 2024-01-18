


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildApplicationAnswerMessage : NetworkMessage
{

public const uint Id = 8254;
public uint MessageId
{
    get { return Id; }
}

public bool accepted;
        public double playerId;
        

public GuildApplicationAnswerMessage()
{
}

public GuildApplicationAnswerMessage(bool accepted, double playerId)
        {
            this.accepted = accepted;
            this.playerId = playerId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(accepted);
            writer.WriteVarLong(playerId);
            

}

public void Deserialize(IDataReader reader)
{

accepted = reader.ReadBoolean();
            playerId = reader.ReadVarUhLong();
            

}


}


}