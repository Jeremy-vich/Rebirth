


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BreachRoomUnlockResultMessage : NetworkMessage
{

public const uint Id = 6865;
public uint MessageId
{
    get { return Id; }
}

public sbyte roomId;
        public sbyte result;
        

public BreachRoomUnlockResultMessage()
{
}

public BreachRoomUnlockResultMessage(sbyte roomId, sbyte result)
        {
            this.roomId = roomId;
            this.result = result;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(roomId);
            writer.WriteSbyte(result);
            

}

public void Deserialize(IDataReader reader)
{

roomId = reader.ReadSbyte();
            result = reader.ReadSbyte();
            

}


}


}