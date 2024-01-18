


















// Generated on 01/30/2023 13:09:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionSpamMessage : NetworkMessage
{

public const uint Id = 835;
public uint MessageId
{
    get { return Id; }
}

public short[] cells;
        

public GameActionSpamMessage()
{
}

public GameActionSpamMessage(short[] cells)
        {
            this.cells = cells;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)cells.Length);
            foreach (var entry in cells)
            {
                 writer.WriteShort(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            cells = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 cells[i] = reader.ReadShort();
            }
            

}


}


}