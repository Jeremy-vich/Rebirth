


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class RemoveSpellModifierMessage : NetworkMessage
{

public const uint Id = 2668;
public uint MessageId
{
    get { return Id; }
}

public double actorId;
        public sbyte modificationType;
        public uint spellId;
        

public RemoveSpellModifierMessage()
{
}

public RemoveSpellModifierMessage(double actorId, sbyte modificationType, uint spellId)
        {
            this.actorId = actorId;
            this.modificationType = modificationType;
            this.spellId = spellId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(actorId);
            writer.WriteSbyte(modificationType);
            writer.WriteVarShort((int)spellId);
            

}

public void Deserialize(IDataReader reader)
{

actorId = reader.ReadDouble();
            modificationType = reader.ReadSbyte();
            spellId = reader.ReadVarUhShort();
            

}


}


}