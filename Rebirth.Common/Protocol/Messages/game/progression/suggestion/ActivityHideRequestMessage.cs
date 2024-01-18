


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ActivityHideRequestMessage : NetworkMessage
{

public const uint Id = 990;
public uint MessageId
{
    get { return Id; }
}

public uint activityId;
        

public ActivityHideRequestMessage()
{
}

public ActivityHideRequestMessage(uint activityId)
        {
            this.activityId = activityId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)activityId);
            

}

public void Deserialize(IDataReader reader)
{

activityId = reader.ReadVarUhShort();
            

}


}


}