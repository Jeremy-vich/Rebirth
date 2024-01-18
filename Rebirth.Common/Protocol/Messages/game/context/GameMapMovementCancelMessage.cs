


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameMapMovementCancelMessage : NetworkMessage
{

public const uint Id = 4833;
public uint MessageId
{
    get { return Id; }
}

public uint cellId;
        

public GameMapMovementCancelMessage()
{
}

public GameMapMovementCancelMessage(uint cellId)
        {
            this.cellId = cellId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)cellId);
            

}

public void Deserialize(IDataReader reader)
{

cellId = reader.ReadVarUhShort();
            

}


}


}