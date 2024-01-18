


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ChallengeFightJoinRefusedMessage : NetworkMessage
{

public const uint Id = 4363;
public uint MessageId
{
    get { return Id; }
}

public double playerId;
        public sbyte reason;
        

public ChallengeFightJoinRefusedMessage()
{
}

public ChallengeFightJoinRefusedMessage(double playerId, sbyte reason)
        {
            this.playerId = playerId;
            this.reason = reason;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(playerId);
            writer.WriteSbyte(reason);
            

}

public void Deserialize(IDataReader reader)
{

playerId = reader.ReadVarUhLong();
            reason = reader.ReadSbyte();
            

}


}


}