


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class QueueStatusMessage : NetworkMessage
{

public const uint Id = 5360;
public uint MessageId
{
    get { return Id; }
}

public ushort position;
        public ushort total;
        

public QueueStatusMessage()
{
}

public QueueStatusMessage(ushort position, ushort total)
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