


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeErrorMessage : NetworkMessage
{

public const uint Id = 8694;
public uint MessageId
{
    get { return Id; }
}

public sbyte errorType;
        

public ExchangeErrorMessage()
{
}

public ExchangeErrorMessage(sbyte errorType)
        {
            this.errorType = errorType;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(errorType);
            

}

public void Deserialize(IDataReader reader)
{

errorType = reader.ReadSbyte();
            

}


}


}