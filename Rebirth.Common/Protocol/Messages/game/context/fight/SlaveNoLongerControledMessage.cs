


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class SlaveNoLongerControledMessage : NetworkMessage
{

public const uint Id = 4651;
public uint MessageId
{
    get { return Id; }
}

public double masterId;
        public double slaveId;
        

public SlaveNoLongerControledMessage()
{
}

public SlaveNoLongerControledMessage(double masterId, double slaveId)
        {
            this.masterId = masterId;
            this.slaveId = slaveId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(masterId);
            writer.WriteDouble(slaveId);
            

}

public void Deserialize(IDataReader reader)
{

masterId = reader.ReadDouble();
            slaveId = reader.ReadDouble();
            

}


}


}