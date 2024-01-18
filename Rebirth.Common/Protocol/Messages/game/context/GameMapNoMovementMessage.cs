


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameMapNoMovementMessage : NetworkMessage
{

public const uint Id = 979;
public uint MessageId
{
    get { return Id; }
}

public short cellX;
        public short cellY;
        

public GameMapNoMovementMessage()
{
}

public GameMapNoMovementMessage(short cellX, short cellY)
        {
            this.cellX = cellX;
            this.cellY = cellY;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(cellX);
            writer.WriteShort(cellY);
            

}

public void Deserialize(IDataReader reader)
{

cellX = reader.ReadShort();
            cellY = reader.ReadShort();
            

}


}


}