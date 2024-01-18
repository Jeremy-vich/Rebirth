


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CharacterCapabilitiesMessage : NetworkMessage
{

public const uint Id = 6638;
public uint MessageId
{
    get { return Id; }
}

public uint guildEmblemSymbolCategories;
        

public CharacterCapabilitiesMessage()
{
}

public CharacterCapabilitiesMessage(uint guildEmblemSymbolCategories)
        {
            this.guildEmblemSymbolCategories = guildEmblemSymbolCategories;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)guildEmblemSymbolCategories);
            

}

public void Deserialize(IDataReader reader)
{

guildEmblemSymbolCategories = reader.ReadVarUhInt();
            

}


}


}