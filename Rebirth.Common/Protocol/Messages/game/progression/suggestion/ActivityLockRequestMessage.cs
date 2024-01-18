


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ActivityLockRequestMessage : NetworkMessage
{

public const uint Id = 3730;
public uint MessageId
{
    get { return Id; }
}

public uint activityId;
        public bool _lock;
        

public ActivityLockRequestMessage()
{
}

public ActivityLockRequestMessage(uint activityId, bool _lock)
        {
            this.activityId = activityId;
            this._lock = _lock;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)activityId);
            writer.WriteBoolean(_lock);
            

}

public void Deserialize(IDataReader reader)
{

activityId = reader.ReadVarUhShort();
            _lock = reader.ReadBoolean();
            

}


}


}