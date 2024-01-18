


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameContextKickMessage : NetworkMessage
{

public const uint Id = 3606;
public uint MessageId
{
    get { return Id; }
}

public double targetId;
        

public GameContextKickMessage()
{
}

public GameContextKickMessage(double targetId)
        {
            this.targetId = targetId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(targetId);
            

}

public void Deserialize(IDataReader reader)
{

targetId = reader.ReadDouble();
            

}


}


}