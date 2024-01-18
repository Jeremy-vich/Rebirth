


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightNewRoundMessage : NetworkMessage
{

public const uint Id = 1995;
public uint MessageId
{
    get { return Id; }
}

public uint roundNumber;
        

public GameFightNewRoundMessage()
{
}

public GameFightNewRoundMessage(uint roundNumber)
        {
            this.roundNumber = roundNumber;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)roundNumber);
            

}

public void Deserialize(IDataReader reader)
{

roundNumber = reader.ReadVarUhInt();
            

}


}


}