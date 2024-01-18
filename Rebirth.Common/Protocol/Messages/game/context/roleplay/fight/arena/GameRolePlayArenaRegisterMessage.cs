


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayArenaRegisterMessage : NetworkMessage
{

public const uint Id = 8654;
public uint MessageId
{
    get { return Id; }
}

public int battleMode;
        

public GameRolePlayArenaRegisterMessage()
{
}

public GameRolePlayArenaRegisterMessage(int battleMode)
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