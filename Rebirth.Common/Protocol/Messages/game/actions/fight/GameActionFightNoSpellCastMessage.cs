


















// Generated on 01/30/2023 13:09:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionFightNoSpellCastMessage : NetworkMessage
{

public const uint Id = 6772;
public uint MessageId
{
    get { return Id; }
}

public uint spellLevelId;
        

public GameActionFightNoSpellCastMessage()
{
}

public GameActionFightNoSpellCastMessage(uint spellLevelId)
        {
            this.spellLevelId = spellLevelId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)spellLevelId);
            

}

public void Deserialize(IDataReader reader)
{

spellLevelId = reader.ReadVarUhInt();
            

}


}


}