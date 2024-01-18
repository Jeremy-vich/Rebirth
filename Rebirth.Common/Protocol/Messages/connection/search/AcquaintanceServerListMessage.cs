


















// Generated on 01/30/2023 13:09:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AcquaintanceServerListMessage : NetworkMessage
{

public const uint Id = 2240;
public uint MessageId
{
    get { return Id; }
}

public uint[] servers;
        

public AcquaintanceServerListMessage()
{
}

public AcquaintanceServerListMessage(uint[] servers)
        {
            this.servers = servers;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)servers.Length);
            foreach (var entry in servers)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            servers = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 servers[i] = reader.ReadVarUhShort();
            }
            

}


}


}