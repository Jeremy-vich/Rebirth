


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class EnterHavenBagRequestMessage : NetworkMessage
{

public const uint Id = 6131;
public uint MessageId
{
    get { return Id; }
}

public double havenBagOwner;
        

public EnterHavenBagRequestMessage()
{
}

public EnterHavenBagRequestMessage(double havenBagOwner)
        {
            this.havenBagOwner = havenBagOwner;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(havenBagOwner);
            

}

public void Deserialize(IDataReader reader)
{

havenBagOwner = reader.ReadVarUhLong();
            

}


}


}