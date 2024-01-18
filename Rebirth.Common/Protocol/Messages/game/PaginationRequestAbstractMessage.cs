


















// Generated on 01/30/2023 13:09:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PaginationRequestAbstractMessage : NetworkMessage
{

public const uint Id = 4893;
public uint MessageId
{
    get { return Id; }
}

public double offset;
        public uint count;
        

public PaginationRequestAbstractMessage()
{
}

public PaginationRequestAbstractMessage(double offset, uint count)
        {
            this.offset = offset;
            this.count = count;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(offset);
            writer.WriteUInt(count);
            

}

public void Deserialize(IDataReader reader)
{

offset = reader.ReadDouble();
            count = reader.ReadUInt();
            

}


}


}