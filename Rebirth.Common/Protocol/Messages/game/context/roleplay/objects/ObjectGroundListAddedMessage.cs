


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectGroundListAddedMessage : NetworkMessage
{

public const uint Id = 2059;
public uint MessageId
{
    get { return Id; }
}

public uint[] cells;
        public uint[] referenceIds;
        

public ObjectGroundListAddedMessage()
{
}

public ObjectGroundListAddedMessage(uint[] cells, uint[] referenceIds)
        {
            this.cells = cells;
            this.referenceIds = referenceIds;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)cells.Length);
            foreach (var entry in cells)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)referenceIds.Length);
            foreach (var entry in referenceIds)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            cells = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 cells[i] = reader.ReadVarUhShort();
            }
            limit = (ushort)reader.ReadUShort();
            referenceIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 referenceIds[i] = reader.ReadVarUhInt();
            }
            

}


}


}