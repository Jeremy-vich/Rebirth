


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class SequenceNumberMessage : NetworkMessage
{

public const uint Id = 8313;
public uint MessageId
{
    get { return Id; }
}

public ushort number;
        

public SequenceNumberMessage()
{
}

public SequenceNumberMessage(ushort number)
        {
            this.number = number;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort(number);
            

}

public void Deserialize(IDataReader reader)
{

number = reader.ReadUShort();
            

}


}


}