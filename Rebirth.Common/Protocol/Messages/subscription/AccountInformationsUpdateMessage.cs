


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AccountInformationsUpdateMessage : NetworkMessage
{

public const uint Id = 5396;
public uint MessageId
{
    get { return Id; }
}

public double subscriptionEndDate;
        

public AccountInformationsUpdateMessage()
{
}

public AccountInformationsUpdateMessage(double subscriptionEndDate)
        {
            this.subscriptionEndDate = subscriptionEndDate;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(subscriptionEndDate);
            

}

public void Deserialize(IDataReader reader)
{

subscriptionEndDate = reader.ReadDouble();
            

}


}


}