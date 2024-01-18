


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRefreshMonsterBoostsMessage : NetworkMessage
{

public const uint Id = 7436;
public uint MessageId
{
    get { return Id; }
}

public Types.MonsterBoosts[] monsterBoosts;
        public Types.MonsterBoosts[] familyBoosts;
        

public GameRefreshMonsterBoostsMessage()
{
}

public GameRefreshMonsterBoostsMessage(Types.MonsterBoosts[] monsterBoosts, Types.MonsterBoosts[] familyBoosts)
        {
            this.monsterBoosts = monsterBoosts;
            this.familyBoosts = familyBoosts;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)monsterBoosts.Length);
            foreach (var entry in monsterBoosts)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)familyBoosts.Length);
            foreach (var entry in familyBoosts)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            monsterBoosts = new Types.MonsterBoosts[limit];
            for (int i = 0; i < limit; i++)
            {
                 monsterBoosts[i] = new Types.MonsterBoosts();
                 monsterBoosts[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            familyBoosts = new Types.MonsterBoosts[limit];
            for (int i = 0; i < limit; i++)
            {
                 familyBoosts[i] = new Types.MonsterBoosts();
                 familyBoosts[i].Deserialize(reader);
            }
            

}


}


}