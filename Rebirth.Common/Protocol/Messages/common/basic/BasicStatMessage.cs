


















// Generated on 01/30/2023 13:09:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BasicStatMessage : NetworkMessage
{

public const uint Id = 1873;
public uint MessageId
{
    get { return Id; }
}

public double timeSpent;
        public uint statId;
        

public BasicStatMessage()
{
}

public BasicStatMessage(double timeSpent, uint statId)
        {
            this.timeSpent = timeSpent;
            this.statId = statId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(timeSpent);
            writer.WriteVarShort((int)statId);
            

}

public void Deserialize(IDataReader reader)
{

timeSpent = reader.ReadDouble();
            statId = reader.ReadVarUhShort();
            

}


}


}