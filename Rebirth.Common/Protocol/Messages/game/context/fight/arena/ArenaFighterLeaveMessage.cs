


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ArenaFighterLeaveMessage : NetworkMessage
{

public const uint Id = 7444;
public uint MessageId
{
    get { return Id; }
}

public Types.CharacterBasicMinimalInformations leaver;
        

public ArenaFighterLeaveMessage()
{
}

public ArenaFighterLeaveMessage(Types.CharacterBasicMinimalInformations leaver)
        {
            this.leaver = leaver;
        }
        

public void Serialize(IDataWriter writer)
{

leaver.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

leaver = new Types.CharacterBasicMinimalInformations();
            leaver.Deserialize(reader);
            

}


}


}