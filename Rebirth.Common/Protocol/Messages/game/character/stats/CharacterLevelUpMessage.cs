


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CharacterLevelUpMessage : NetworkMessage
{

public const uint Id = 1846;
public uint MessageId
{
    get { return Id; }
}

public uint newLevel;
        

public CharacterLevelUpMessage()
{
}

public CharacterLevelUpMessage(uint newLevel)
        {
            this.newLevel = newLevel;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)newLevel);
            

}

public void Deserialize(IDataReader reader)
{

newLevel = reader.ReadVarUhShort();
            

}


}


}