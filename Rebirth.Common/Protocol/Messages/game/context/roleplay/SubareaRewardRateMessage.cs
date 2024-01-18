


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class SubareaRewardRateMessage : NetworkMessage
{

public const uint Id = 7737;
public uint MessageId
{
    get { return Id; }
}

public int subAreaRate;
        

public SubareaRewardRateMessage()
{
}

public SubareaRewardRateMessage(int subAreaRate)
        {
            this.subAreaRate = subAreaRate;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)subAreaRate);
            

}

public void Deserialize(IDataReader reader)
{

subAreaRate = reader.ReadVarShort();
            

}


}


}