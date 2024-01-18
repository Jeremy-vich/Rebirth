


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightJoinRequestMessage : NetworkMessage
{

public const uint Id = 6094;
public uint MessageId
{
    get { return Id; }
}

public double fighterId;
        public uint fightId;
        

public GameFightJoinRequestMessage()
{
}

public GameFightJoinRequestMessage(double fighterId, uint fightId)
        {
            this.fighterId = fighterId;
            this.fightId = fightId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(fighterId);
            writer.WriteVarShort((int)fightId);
            

}

public void Deserialize(IDataReader reader)
{

fighterId = reader.ReadDouble();
            fightId = reader.ReadVarUhShort();
            

}


}


}