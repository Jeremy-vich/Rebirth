


















// Generated on 01/30/2023 13:09:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class NumericWhoIsMessage : NetworkMessage
{

public const uint Id = 4988;
public uint MessageId
{
    get { return Id; }
}

public double playerId;
        public int accountId;
        

public NumericWhoIsMessage()
{
}

public NumericWhoIsMessage(double playerId, int accountId)
        {
            this.playerId = playerId;
            this.accountId = accountId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(playerId);
            writer.WriteInt(accountId);
            

}

public void Deserialize(IDataReader reader)
{

playerId = reader.ReadVarUhLong();
            accountId = reader.ReadInt();
            

}


}


}