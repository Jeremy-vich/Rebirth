


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AnomalyOpenedMessage : NetworkMessage
{

public const uint Id = 5002;
public uint MessageId
{
    get { return Id; }
}

public uint subAreaId;
        

public AnomalyOpenedMessage()
{
}

public AnomalyOpenedMessage(uint subAreaId)
        {
            this.subAreaId = subAreaId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)subAreaId);
            

}

public void Deserialize(IDataReader reader)
{

subAreaId = reader.ReadVarUhShort();
            

}


}


}