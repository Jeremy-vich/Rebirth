


















// Generated on 01/30/2023 13:09:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PaginationAnswerAbstractMessage : NetworkMessage
{

public const uint Id = 213;
public uint MessageId
{
    get { return Id; }
}

public double offset;
        public uint count;
        public uint total;
        

public PaginationAnswerAbstractMessage()
{
}

public PaginationAnswerAbstractMessage(double offset, uint count, uint total)
        {
            this.offset = offset;
            this.count = count;
            this.total = total;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(offset);
            writer.WriteUInt(count);
            writer.WriteUInt(total);
            

}

public void Deserialize(IDataReader reader)
{

offset = reader.ReadDouble();
            count = reader.ReadUInt();
            total = reader.ReadUInt();
            

}


}


}