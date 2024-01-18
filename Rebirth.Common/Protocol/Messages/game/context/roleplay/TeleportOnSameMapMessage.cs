


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TeleportOnSameMapMessage : NetworkMessage
{

public const uint Id = 8386;
public uint MessageId
{
    get { return Id; }
}

public double targetId;
        public uint cellId;
        

public TeleportOnSameMapMessage()
{
}

public TeleportOnSameMapMessage(double targetId, uint cellId)
        {
            this.targetId = targetId;
            this.cellId = cellId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(targetId);
            writer.WriteVarShort((int)cellId);
            

}

public void Deserialize(IDataReader reader)
{

targetId = reader.ReadDouble();
            cellId = reader.ReadVarUhShort();
            

}


}


}