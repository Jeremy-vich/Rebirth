


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeCraftCountRequestMessage : NetworkMessage
{

public const uint Id = 9737;
public uint MessageId
{
    get { return Id; }
}

public int count;
        

public ExchangeCraftCountRequestMessage()
{
}

public ExchangeCraftCountRequestMessage(int count)
        {
            this.count = count;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)count);
            

}

public void Deserialize(IDataReader reader)
{

count = reader.ReadVarInt();
            

}


}


}