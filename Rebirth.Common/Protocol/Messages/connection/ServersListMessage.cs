


















// Generated on 01/30/2023 13:09:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ServersListMessage : NetworkMessage
{

public const uint Id = 1619;
public uint MessageId
{
    get { return Id; }
}

public Types.GameServerInformations[] servers;
        public bool canCreateNewCharacter;
        

public ServersListMessage()
{
}

public ServersListMessage(Types.GameServerInformations[] servers, bool canCreateNewCharacter)
        {
            this.servers = servers;
            this.canCreateNewCharacter = canCreateNewCharacter;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)servers.Length);
            foreach (var entry in servers)
            {
                 entry.Serialize(writer);
            }
            writer.WriteBoolean(canCreateNewCharacter);
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            servers = new Types.GameServerInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 servers[i] = new Types.GameServerInformations();
                 servers[i].Deserialize(reader);
            }
            canCreateNewCharacter = reader.ReadBoolean();
            

}


}


}