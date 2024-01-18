


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ForgettableSpellClientActionMessage : NetworkMessage
{

public const uint Id = 2288;
public uint MessageId
{
    get { return Id; }
}

public int spellId;
        public sbyte action;
        

public ForgettableSpellClientActionMessage()
{
}

public ForgettableSpellClientActionMessage(int spellId, sbyte action)
        {
            this.spellId = spellId;
            this.action = action;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(spellId);
            writer.WriteSbyte(action);
            

}

public void Deserialize(IDataReader reader)
{

spellId = reader.ReadInt();
            action = reader.ReadSbyte();
            

}


}


}