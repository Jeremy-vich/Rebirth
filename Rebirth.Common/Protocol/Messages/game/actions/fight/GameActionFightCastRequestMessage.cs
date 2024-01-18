


















// Generated on 01/30/2023 13:09:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionFightCastRequestMessage : NetworkMessage
{

public const uint Id = 3791;
public uint MessageId
{
    get { return Id; }
}

public uint spellId;
        public short cellId;
        

public GameActionFightCastRequestMessage()
{
}

public GameActionFightCastRequestMessage(uint spellId, short cellId)
        {
            this.spellId = spellId;
            this.cellId = cellId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)spellId);
            writer.WriteShort(cellId);
            

}

public void Deserialize(IDataReader reader)
{

spellId = reader.ReadVarUhShort();
            cellId = reader.ReadShort();
            

}


}


}