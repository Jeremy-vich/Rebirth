


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PrismFightSwapRequestMessage : NetworkMessage
{

public const uint Id = 5555;
public uint MessageId
{
    get { return Id; }
}

public uint subAreaId;
        public double targetId;
        

public PrismFightSwapRequestMessage()
{
}

public PrismFightSwapRequestMessage(uint subAreaId, double targetId)
        {
            this.subAreaId = subAreaId;
            this.targetId = targetId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)subAreaId);
            writer.WriteVarLong(targetId);
            

}

public void Deserialize(IDataReader reader)
{

subAreaId = reader.ReadVarUhShort();
            targetId = reader.ReadVarUhLong();
            

}


}


}