


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class LockableStateUpdateAbstractMessage : NetworkMessage
{

public const uint Id = 4249;
public uint MessageId
{
    get { return Id; }
}

public bool locked;
        

public LockableStateUpdateAbstractMessage()
{
}

public LockableStateUpdateAbstractMessage(bool locked)
        {
            this.locked = locked;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(locked);
            

}

public void Deserialize(IDataReader reader)
{

locked = reader.ReadBoolean();
            

}


}


}