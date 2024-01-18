


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class IgnoredAddFailureMessage : NetworkMessage
{

public const uint Id = 1684;
public uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        

public IgnoredAddFailureMessage()
{
}

public IgnoredAddFailureMessage(sbyte reason)
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