


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HouseToSellListRequestMessage : NetworkMessage
{

public const uint Id = 2840;
public uint MessageId
{
    get { return Id; }
}

public uint pageIndex;
        

public HouseToSellListRequestMessage()
{
}

public HouseToSellListRequestMessage(uint pageIndex)
        {
            this.pageIndex = pageIndex;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)pageIndex);
            

}

public void Deserialize(IDataReader reader)
{

pageIndex = reader.ReadVarUhShort();
            

}


}


}