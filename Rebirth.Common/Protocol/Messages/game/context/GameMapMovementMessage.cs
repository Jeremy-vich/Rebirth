


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameMapMovementMessage : NetworkMessage
{

public const uint Id = 7425;
public uint MessageId
{
    get { return Id; }
}

public short[] keyMovements;
        public short forcedDirection;
        public double actorId;
        

public GameMapMovementMessage()
{
}

public GameMapMovementMessage(short[] keyMovements, short forcedDirection, double actorId)
        {
            this.keyMovements = keyMovements;
            this.forcedDirection = forcedDirection;
            this.actorId = actorId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)keyMovements.Length);
            foreach (var entry in keyMovements)
            {
                 writer.WriteShort(entry);
            }
            writer.WriteShort(forcedDirection);
            writer.WriteDouble(actorId);
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            keyMovements = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 keyMovements[i] = reader.ReadShort();
            }
            forcedDirection = reader.ReadShort();
            actorId = reader.ReadDouble();
            

}


}


}