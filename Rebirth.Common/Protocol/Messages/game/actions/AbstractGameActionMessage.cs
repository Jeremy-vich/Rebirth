


















// Generated on 01/30/2023 13:09:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AbstractGameActionMessage : NetworkMessage
{

public const uint Id = 2888;
public uint MessageId
{
    get { return Id; }
}

public uint actionId;
        public double sourceId;
        

public AbstractGameActionMessage()
{
}

public AbstractGameActionMessage(uint actionId, double sourceId)
        {
            this.actionId = actionId;
            this.sourceId = sourceId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)actionId);
            writer.WriteDouble(sourceId);
            

}

public void Deserialize(IDataReader reader)
{

actionId = reader.ReadVarUhShort();
            sourceId = reader.ReadDouble();
            

}


}


}