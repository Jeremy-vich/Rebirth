


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildApplicationReceivedMessage : NetworkMessage
{

public const uint Id = 3627;
public uint MessageId
{
    get { return Id; }
}

public string playerName;
        public double playerId;
        

public GuildApplicationReceivedMessage()
{
}

public GuildApplicationReceivedMessage(string playerName, double playerId)
        {
            this.playerName = playerName;
            this.playerId = playerId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(playerName);
            writer.WriteVarLong(playerId);
            

}

public void Deserialize(IDataReader reader)
{

playerName = reader.ReadUTF();
            playerId = reader.ReadVarUhLong();
            

}


}


}