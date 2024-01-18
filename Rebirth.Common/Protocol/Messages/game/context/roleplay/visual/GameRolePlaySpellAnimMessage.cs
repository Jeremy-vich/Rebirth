


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlaySpellAnimMessage : NetworkMessage
{

public const uint Id = 5588;
public uint MessageId
{
    get { return Id; }
}

public double casterId;
        public uint targetCellId;
        public uint spellId;
        public short spellLevel;
        public short direction;
        

public GameRolePlaySpellAnimMessage()
{
}

public GameRolePlaySpellAnimMessage(double casterId, uint targetCellId, uint spellId, short spellLevel, short direction)
        {
            this.casterId = casterId;
            this.targetCellId = targetCellId;
            this.spellId = spellId;
            this.spellLevel = spellLevel;
            this.direction = direction;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(casterId);
            writer.WriteVarShort((int)targetCellId);
            writer.WriteVarShort((int)spellId);
            writer.WriteShort(spellLevel);
            writer.WriteShort(direction);
            

}

public void Deserialize(IDataReader reader)
{

casterId = reader.ReadVarUhLong();
            targetCellId = reader.ReadVarUhShort();
            spellId = reader.ReadVarUhShort();
            spellLevel = reader.ReadShort();
            direction = reader.ReadShort();
            

}


}


}