


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class LoginQueueStatusMessage : NetworkMessage
{

public const uint Id = 5654;
public uint MessageId
{
    get { return Id; }
}

public ushort position;
        public ushort total;
        

public LoginQueueStatusMessage()
{
}

public LoginQueueStatusMessage(ushort position, ushort total)
        {
            this.position = position;
            this.total = total;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort(position);
            writer.WriteUShort(total);
            

}

public void Deserialize(IDataReader reader)
{

position = reader.ReadUShort();
            total = reader.ReadUShort();
            

}


}


}