


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectUseOnCellMessage : ObjectUseMessage
{

public const uint Id = 8862;
public uint MessageId
{
    get { return Id; }
}

public uint cells;
        

public ObjectUseOnCellMessage()
{
}

public ObjectUseOnCellMessage(uint objectUID, uint cells)
         : base(objectUID)
        {
            this.cells = cells;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)cells);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            cells = reader.ReadVarUhShort();
            

}


}


}