


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TeleportPlayerAnswerMessage : NetworkMessage
{

public const uint Id = 9074;
public uint MessageId
{
    get { return Id; }
}

public bool accept;
        public double requesterId;
        

public TeleportPlayerAnswerMessage()
{
}

public TeleportPlayerAnswerMessage(bool accept, double requesterId)
        {
            this.accept = accept;
            this.requesterId = requesterId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(accept);
            writer.WriteVarLong(requesterId);
            

}

public void Deserialize(IDataReader reader)
{

accept = reader.ReadBoolean();
            requesterId = reader.ReadVarUhLong();
            

}


}


}