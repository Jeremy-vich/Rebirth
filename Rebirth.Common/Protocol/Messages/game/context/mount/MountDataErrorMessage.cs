


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MountDataErrorMessage : NetworkMessage
{

public const uint Id = 6076;
public uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        

public MountDataErrorMessage()
{
}

public MountDataErrorMessage(sbyte reason)
        {
            this.reason = reason;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(reason);
            

}

public void Deserialize(IDataReader reader)
{

reason = reader.ReadSbyte();
            

}


}


}