


















// Generated on 01/30/2023 13:09:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionFightSpellCooldownVariationMessage : AbstractGameActionMessage
{

public const uint Id = 5388;
public uint MessageId
{
    get { return Id; }
}

public double targetId;
        public uint spellId;
        public int value;
        

public GameActionFightSpellCooldownVariationMessage()
{
}

public GameActionFightSpellCooldownVariationMessage(uint actionId, double sourceId, double targetId, uint spellId, int value)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.spellId = spellId;
            this.value = value;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarShort((int)spellId);
            writer.WriteVarShort((int)value);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            spellId = reader.ReadVarUhShort();
            value = reader.ReadVarShort();
            

}


}


}