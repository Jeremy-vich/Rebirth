


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PaddockMoveItemRequestMessage : NetworkMessage
{

public const uint Id = 2379;
public uint MessageId
{
    get { return Id; }
}

public uint oldCellId;
        public uint newCellId;
        

public PaddockMoveItemRequestMessage()
{
}

public PaddockMoveItemRequestMessage(uint oldCellId, uint newCellId)
        {
            this.oldCellId = oldCellId;
            this.newCellId = newCellId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)oldCellId);
            writer.WriteVarShort((int)newCellId);
            

}

public void Deserialize(IDataReader reader)
{

oldCellId = reader.ReadVarUhShort();
            newCellId = reader.ReadVarUhShort();
            

}


}


}