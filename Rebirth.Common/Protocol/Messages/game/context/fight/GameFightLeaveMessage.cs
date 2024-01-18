


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightLeaveMessage : NetworkMessage
{

public const uint Id = 5613;
public uint MessageId
{
    get { return Id; }
}

public double charId;
        

public GameFightLeaveMessage()
{
}

public GameFightLeaveMessage(double charId)
        {
            this.charId = charId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(charId);
            

}

public void Deserialize(IDataReader reader)
{

charId = reader.ReadDouble();
            

}


}


}