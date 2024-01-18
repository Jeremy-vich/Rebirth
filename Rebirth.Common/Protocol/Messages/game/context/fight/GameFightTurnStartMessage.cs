


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightTurnStartMessage : NetworkMessage
{

public const uint Id = 5467;
public uint MessageId
{
    get { return Id; }
}

public double id;
        public uint waitTime;
        

public GameFightTurnStartMessage()
{
}

public GameFightTurnStartMessage(double id, uint waitTime)
        {
            this.id = id;
            this.waitTime = waitTime;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(id);
            writer.WriteVarInt((int)waitTime);
            

}

public void Deserialize(IDataReader reader)
{

id = reader.ReadDouble();
            waitTime = reader.ReadVarUhInt();
            

}


}


}