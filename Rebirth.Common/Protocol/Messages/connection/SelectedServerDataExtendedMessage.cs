


















// Generated on 01/30/2023 13:09:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class SelectedServerDataExtendedMessage : SelectedServerDataMessage
{

public const uint Id = 9230;
public uint MessageId
{
    get { return Id; }
}

public Types.GameServerInformations[] servers;
        

public SelectedServerDataExtendedMessage()
{
}

public SelectedServerDataExtendedMessage(uint serverId, string address, uint[] ports, bool canCreateNewCharacter, sbyte[] ticket, Types.GameServerInformations[] servers)
         : base(serverId, address, ports, canCreateNewCharacter, ticket)
        {
            this.servers = servers;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)servers.Length);
            foreach (var entry in servers)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            servers = new Types.GameServerInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 servers[i] = new Types.GameServerInformations();
                 servers[i].Deserialize(reader);
            }
            

}


}


}