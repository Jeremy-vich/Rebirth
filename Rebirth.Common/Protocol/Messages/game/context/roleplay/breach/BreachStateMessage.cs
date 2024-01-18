


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BreachStateMessage : NetworkMessage
{

public const uint Id = 6068;
public uint MessageId
{
    get { return Id; }
}

public Types.CharacterMinimalInformations owner;
        public Types.ObjectEffectInteger[] bonuses;
        public uint bugdet;
        public bool saved;
        

public BreachStateMessage()
{
}

public BreachStateMessage(Types.CharacterMinimalInformations owner, Types.ObjectEffectInteger[] bonuses, uint bugdet, bool saved)
        {
            this.owner = owner;
            this.bonuses = bonuses;
            this.bugdet = bugdet;
            this.saved = saved;
        }
        

public void Serialize(IDataWriter writer)
{

owner.Serialize(writer);
            writer.WriteShort((short)bonuses.Length);
            foreach (var entry in bonuses)
            {
                 entry.Serialize(writer);
            }
            writer.WriteVarInt((int)bugdet);
            writer.WriteBoolean(saved);
            

}

public void Deserialize(IDataReader reader)
{

owner = new Types.CharacterMinimalInformations();
            owner.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            bonuses = new Types.ObjectEffectInteger[limit];
            for (int i = 0; i < limit; i++)
            {
                 bonuses[i] = new Types.ObjectEffectInteger();
                 bonuses[i].Deserialize(reader);
            }
            bugdet = reader.ReadVarUhInt();
            saved = reader.ReadBoolean();
            

}


}


}