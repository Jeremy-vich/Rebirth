


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayArenaRegistrationStatusMessage : NetworkMessage
{

public const uint Id = 9108;
public uint MessageId
{
    get { return Id; }
}

public bool registered;
        public sbyte step;
        public int battleMode;
        

public GameRolePlayArenaRegistrationStatusMessage()
{
}

public GameRolePlayArenaRegistrationStatusMessage(bool registered, sbyte step, int battleMode)
        {
            this.registered = registered;
            this.step = step;
            this.battleMode = battleMode;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(registered);
            writer.WriteSbyte(step);
            writer.WriteInt(battleMode);
            

}

public void Deserialize(IDataReader reader)
{

registered = reader.ReadBoolean();
            step = reader.ReadSbyte();
            battleMode = reader.ReadInt();
            

}


}


}