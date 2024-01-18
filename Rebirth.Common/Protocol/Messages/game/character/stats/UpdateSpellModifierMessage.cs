


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class UpdateSpellModifierMessage : NetworkMessage
{

public const uint Id = 3555;
public uint MessageId
{
    get { return Id; }
}

public double actorId;
        public Types.CharacterSpellModification spellModifier;
        

public UpdateSpellModifierMessage()
{
}

public UpdateSpellModifierMessage(double actorId, Types.CharacterSpellModification spellModifier)
        {
            this.actorId = actorId;
            this.spellModifier = spellModifier;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(actorId);
            spellModifier.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

actorId = reader.ReadDouble();
            spellModifier = new Types.CharacterSpellModification();
            spellModifier.Deserialize(reader);
            

}


}


}