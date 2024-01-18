


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeBidHouseInListUpdatedMessage : ExchangeBidHouseInListAddedMessage
{

public const uint Id = 3268;
public uint MessageId
{
    get { return Id; }
}



public ExchangeBidHouseInListUpdatedMessage()
{
}

public ExchangeBidHouseInListUpdatedMessage(int itemUID, uint objectGID, int objectType, Types.ObjectEffect[] effects, double[] prices)
         : base(itemUID, objectGID, objectType, effects, prices)
        {
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}