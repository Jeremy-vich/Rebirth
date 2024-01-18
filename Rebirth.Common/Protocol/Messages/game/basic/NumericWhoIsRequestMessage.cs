


















// Generated on 01/30/2023 13:09:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class NumericWhoIsRequestMessage : NetworkMessage
{

public const uint Id = 7392;
public uint MessageId
{
    get { return Id; }
}

public double playerId;
        

public NumericWhoIsRequestMessage()
{
}

public NumericWhoIsRequestMessage(double playerId)
        {
            this.playerId = playerId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(playerId);
            

}

public void Deserialize(IDataReader reader)
{

playerId = reader.ReadVarUhLong();
            

}


}


}