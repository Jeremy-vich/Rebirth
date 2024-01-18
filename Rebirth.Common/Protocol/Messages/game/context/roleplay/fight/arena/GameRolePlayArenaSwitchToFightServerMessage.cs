


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayArenaSwitchToFightServerMessage : NetworkMessage
{

public const uint Id = 6455;
public uint MessageId
{
    get { return Id; }
}

public string address;
        public uint[] ports;
        public string token;
        

public GameRolePlayArenaSwitchToFightServerMessage()
{
}

public GameRolePlayArenaSwitchToFightServerMessage(string address, uint[] ports, string token)
        {
            this.address = address;
            this.ports = ports;
            this.token = token;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(address);
            writer.WriteShort((short)ports.Length);
            foreach (var entry in ports)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteUTF(token);
            

}

public void Deserialize(IDataReader reader)
{

address = reader.ReadUTF();
            var limit = (ushort)reader.ReadUShort();
            ports = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 ports[i] = reader.ReadVarUhShort();
            }
            token = reader.ReadUTF();
            

}


}


}