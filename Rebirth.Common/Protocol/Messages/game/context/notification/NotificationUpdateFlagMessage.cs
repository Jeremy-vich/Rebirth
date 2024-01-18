


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class NotificationUpdateFlagMessage : NetworkMessage
{

public const uint Id = 4763;
public uint MessageId
{
    get { return Id; }
}

public uint index;
        

public NotificationUpdateFlagMessage()
{
}

public NotificationUpdateFlagMessage(uint index)
        {
            this.index = index;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)index);
            

}

public void Deserialize(IDataReader reader)
{

index = reader.ReadVarUhShort();
            

}


}


}