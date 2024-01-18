


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MapRunningFightDetailsMessage : NetworkMessage
{

public const uint Id = 4182;
public uint MessageId
{
    get { return Id; }
}

public uint fightId;
        public Types.GameFightFighterLightInformations[] attackers;
        public Types.GameFightFighterLightInformations[] defenders;
        

public MapRunningFightDetailsMessage()
{
}

public MapRunningFightDetailsMessage(uint fightId, Types.GameFightFighterLightInformations[] attackers, Types.GameFightFighterLightInformations[] defenders)
        {
            this.fightId = fightId;
            this.attackers = attackers;
            this.defenders = defenders;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)fightId);
            writer.WriteShort((short)attackers.Length);
            foreach (var entry in attackers)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)defenders.Length);
            foreach (var entry in defenders)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

fightId = reader.ReadVarUhShort();
            var limit = (ushort)reader.ReadUShort();
            attackers = new Types.GameFightFighterLightInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 attackers[i] = ProtocolTypeManager.GetInstance<Types.GameFightFighterLightInformations>(reader.ReadUShort());
                 attackers[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            defenders = new Types.GameFightFighterLightInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 defenders[i] = ProtocolTypeManager.GetInstance<Types.GameFightFighterLightInformations>(reader.ReadUShort());
                 defenders[i].Deserialize(reader);
            }
            

}


}


}