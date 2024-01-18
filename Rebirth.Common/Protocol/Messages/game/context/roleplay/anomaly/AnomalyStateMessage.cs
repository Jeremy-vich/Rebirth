


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AnomalyStateMessage : NetworkMessage
{

public const uint Id = 1610;
public uint MessageId
{
    get { return Id; }
}

public uint subAreaId;
        public bool open;
        public double closingTime;
        

public AnomalyStateMessage()
{
}

public AnomalyStateMessage(uint subAreaId, bool open, double closingTime)
        {
            this.subAreaId = subAreaId;
            this.open = open;
            this.closingTime = closingTime;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)subAreaId);
            writer.WriteBoolean(open);
            writer.WriteVarLong(closingTime);
            

}

public void Deserialize(IDataReader reader)
{

subAreaId = reader.ReadVarUhShort();
            open = reader.ReadBoolean();
            closingTime = reader.ReadVarUhLong();
            

}


}


}