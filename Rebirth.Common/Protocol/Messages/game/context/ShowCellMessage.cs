


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ShowCellMessage : NetworkMessage
{

public const uint Id = 4902;
public uint MessageId
{
    get { return Id; }
}

public double sourceId;
        public uint cellId;
        

public ShowCellMessage()
{
}

public ShowCellMessage(double sourceId, uint cellId)
        {
            this.sourceId = sourceId;
            this.cellId = cellId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(sourceId);
            writer.WriteVarShort((int)cellId);
            

}

public void Deserialize(IDataReader reader)
{

sourceId = reader.ReadDouble();
            cellId = reader.ReadVarUhShort();
            

}


}


}