


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeCraftResultMessage : NetworkMessage
{

public const uint Id = 3666;
public uint MessageId
{
    get { return Id; }
}

public sbyte craftResult;
        

public ExchangeCraftResultMessage()
{
}

public ExchangeCraftResultMessage(sbyte craftResult)
        {
            this.craftResult = craftResult;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(craftResult);
            

}

public void Deserialize(IDataReader reader)
{

craftResult = reader.ReadSbyte();
            

}


}


}