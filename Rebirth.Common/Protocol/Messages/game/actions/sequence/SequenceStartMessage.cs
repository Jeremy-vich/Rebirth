


















// Generated on 01/30/2023 13:09:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class SequenceStartMessage : NetworkMessage
{

public const uint Id = 4935;
public uint MessageId
{
    get { return Id; }
}

public sbyte sequenceType;
        public double authorId;
        

public SequenceStartMessage()
{
}

public SequenceStartMessage(sbyte sequenceType, double authorId)
        {
            this.sequenceType = sequenceType;
            this.authorId = authorId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(sequenceType);
            writer.WriteDouble(authorId);
            

}

public void Deserialize(IDataReader reader)
{

sequenceType = reader.ReadSbyte();
            authorId = reader.ReadDouble();
            

}


}


}