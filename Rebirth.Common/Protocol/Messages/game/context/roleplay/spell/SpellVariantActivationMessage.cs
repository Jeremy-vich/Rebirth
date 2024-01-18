


















// Generated on 01/30/2023 13:09:19
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class SpellVariantActivationMessage : NetworkMessage
{

public const uint Id = 3481;
public uint MessageId
{
    get { return Id; }
}

public uint spellId;
        public bool result;
        

public SpellVariantActivationMessage()
{
}

public SpellVariantActivationMessage(uint spellId, bool result)
        {
            this.spellId = spellId;
            this.result = result;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)spellId);
            writer.WriteBoolean(result);
            

}

public void Deserialize(IDataReader reader)
{

spellId = reader.ReadVarUhShort();
            result = reader.ReadBoolean();
            

}


}


}