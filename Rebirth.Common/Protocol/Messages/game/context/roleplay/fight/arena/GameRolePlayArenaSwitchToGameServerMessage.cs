


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayArenaSwitchToGameServerMessage : NetworkMessage
{

public const uint Id = 7604;
public uint MessageId
{
    get { return Id; }
}

public bool validToken;
        public string token;
        public short homeServerId;
        

public GameRolePlayArenaSwitchToGameServerMessage()
{
}

public GameRolePlayArenaSwitchToGameServerMessage(bool validToken, string token, short homeServerId)
        {
            this.validToken = validToken;
            this.token = token;
            this.homeServerId = homeServerId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(validToken);
            writer.WriteUTF(token);
            writer.WriteShort(homeServerId);
            

}

public void Deserialize(IDataReader reader)
{

validToken = reader.ReadBoolean();
            token = reader.ReadUTF();
            homeServerId = reader.ReadShort();
            

}


}


}