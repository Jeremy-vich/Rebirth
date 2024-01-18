


















// Generated on 01/30/2023 13:09:19
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class SpellVariantActivationRequestMessage : NetworkMessage
{

public const uint Id = 8977;
public uint MessageId
{
    get { return Id; }
}

public uint spellId;
        

public SpellVariantActivationRequestMessage()
{
}

public SpellVariantActivationRequestMessage(uint spellId)
        {
            this.spellId = spellId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)spellId);
            

}

public void Deserialize(IDataReader reader)
{

spellId = reader.ReadVarUhShort();
            

}


}


}