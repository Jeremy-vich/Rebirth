


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildSpellUpgradeRequestMessage : NetworkMessage
{

public const uint Id = 2636;
public uint MessageId
{
    get { return Id; }
}

public int spellId;
        

public GuildSpellUpgradeRequestMessage()
{
}

public GuildSpellUpgradeRequestMessage(int spellId)
        {
            this.spellId = spellId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(spellId);
            

}

public void Deserialize(IDataReader reader)
{

spellId = reader.ReadInt();
            

}


}


}