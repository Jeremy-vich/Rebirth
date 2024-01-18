


















// Generated on 01/30/2023 13:09:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionAcknowledgementMessage : NetworkMessage
{

public const uint Id = 4836;
public uint MessageId
{
    get { return Id; }
}

public bool valid;
        public sbyte actionId;
        

public GameActionAcknowledgementMessage()
{
}

public GameActionAcknowledgementMessage(bool valid, sbyte actionId)
        {
            this.valid = valid;
            this.actionId = actionId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(valid);
            writer.WriteSbyte(actionId);
            

}

public void Deserialize(IDataReader reader)
{

valid = reader.ReadBoolean();
            actionId = reader.ReadSbyte();
            

}


}


}