


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectGroundRemovedMessage : NetworkMessage
{

public const uint Id = 416;
public uint MessageId
{
    get { return Id; }
}

public uint cell;
        

public ObjectGroundRemovedMessage()
{
}

public ObjectGroundRemovedMessage(uint cell)
        {
            this.cell = cell;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)cell);
            

}

public void Deserialize(IDataReader reader)
{

cell = reader.ReadVarUhShort();
            

}


}


}