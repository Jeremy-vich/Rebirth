


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayArenaRegistrationWarningMessage : NetworkMessage
{

public const uint Id = 3691;
public uint MessageId
{
    get { return Id; }
}

public int battleMode;
        

public GameRolePlayArenaRegistrationWarningMessage()
{
}

public GameRolePlayArenaRegistrationWarningMessage(int battleMode)
        {
            this.battleMode = battleMode;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(battleMode);
            

}

public void Deserialize(IDataReader reader)
{

battleMode = reader.ReadInt();
            

}


}


}