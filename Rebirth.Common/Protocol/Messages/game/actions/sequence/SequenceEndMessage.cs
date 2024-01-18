


















// Generated on 01/30/2023 13:09:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class SequenceEndMessage : NetworkMessage
{

public const uint Id = 4552;
public uint MessageId
{
    get { return Id; }
}

public uint actionId;
        public double authorId;
        public sbyte sequenceType;
        

public SequenceEndMessage()
{
}

public SequenceEndMessage(uint actionId, double authorId, sbyte sequenceType)
        {
            this.actionId = actionId;
            this.authorId = authorId;
            this.sequenceType = sequenceType;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)actionId);
            writer.WriteDouble(authorId);
            writer.WriteSbyte(sequenceType);
            

}

public void Deserialize(IDataReader reader)
{

actionId = reader.ReadVarUhShort();
            authorId = reader.ReadDouble();
            sequenceType = reader.ReadSbyte();
            

}


}


}