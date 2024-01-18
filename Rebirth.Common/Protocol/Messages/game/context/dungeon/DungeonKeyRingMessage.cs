


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class DungeonKeyRingMessage : NetworkMessage
{

public const uint Id = 2456;
public uint MessageId
{
    get { return Id; }
}

public uint[] availables;
        public uint[] unavailables;
        

public DungeonKeyRingMessage()
{
}

public DungeonKeyRingMessage(uint[] availables, uint[] unavailables)
        {
            this.availables = availables;
            this.unavailables = unavailables;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)availables.Length);
            foreach (var entry in availables)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)unavailables.Length);
            foreach (var entry in unavailables)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            availables = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 availables[i] = reader.ReadVarUhShort();
            }
            limit = (ushort)reader.ReadUShort();
            unavailables = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 unavailables[i] = reader.ReadVarUhShort();
            }
            

}


}


}