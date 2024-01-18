


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayArenaPlayerBehavioursMessage : NetworkMessage
{

public const uint Id = 3636;
public uint MessageId
{
    get { return Id; }
}

public string[] flags;
        public string[] sanctions;
        public int banDuration;
        

public GameRolePlayArenaPlayerBehavioursMessage()
{
}

public GameRolePlayArenaPlayerBehavioursMessage(string[] flags, string[] sanctions, int banDuration)
        {
            this.flags = flags;
            this.sanctions = sanctions;
            this.banDuration = banDuration;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)flags.Length);
            foreach (var entry in flags)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteShort((short)sanctions.Length);
            foreach (var entry in sanctions)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteInt(banDuration);
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            flags = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 flags[i] = reader.ReadUTF();
            }
            limit = (ushort)reader.ReadUShort();
            sanctions = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 sanctions[i] = reader.ReadUTF();
            }
            banDuration = reader.ReadInt();
            

}


}


}