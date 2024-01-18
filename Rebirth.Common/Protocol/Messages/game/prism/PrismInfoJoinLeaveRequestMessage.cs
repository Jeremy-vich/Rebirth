


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PrismInfoJoinLeaveRequestMessage : NetworkMessage
{

public const uint Id = 9586;
public uint MessageId
{
    get { return Id; }
}

public bool join;
        

public PrismInfoJoinLeaveRequestMessage()
{
}

public PrismInfoJoinLeaveRequestMessage(bool join)
        {
            this.join = join;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(join);
            

}

public void Deserialize(IDataReader reader)
{

join = reader.ReadBoolean();
            

}


}


}