


















// Generated on 01/30/2023 13:09:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceFactsMessage : NetworkMessage
{

public const uint Id = 5026;
public uint MessageId
{
    get { return Id; }
}

public Types.AllianceFactSheetInformations infos;
        public Types.GuildInAllianceInformations[] guilds;
        public uint[] controlledSubareaIds;
        public double leaderCharacterId;
        public string leaderCharacterName;
        

public AllianceFactsMessage()
{
}

public AllianceFactsMessage(Types.AllianceFactSheetInformations infos, Types.GuildInAllianceInformations[] guilds, uint[] controlledSubareaIds, double leaderCharacterId, string leaderCharacterName)
        {
            this.infos = infos;
            this.guilds = guilds;
            this.controlledSubareaIds = controlledSubareaIds;
            this.leaderCharacterId = leaderCharacterId;
            this.leaderCharacterName = leaderCharacterName;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(infos.TypeId);
            infos.Serialize(writer);
            writer.WriteShort((short)guilds.Length);
            foreach (var entry in guilds)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)controlledSubareaIds.Length);
            foreach (var entry in controlledSubareaIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteVarLong(leaderCharacterId);
            writer.WriteUTF(leaderCharacterName);
            

}

public void Deserialize(IDataReader reader)
{

infos = ProtocolTypeManager.GetInstance<Types.AllianceFactSheetInformations>(reader.ReadUShort());
            infos.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            guilds = new Types.GuildInAllianceInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 guilds[i] = new Types.GuildInAllianceInformations();
                 guilds[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            controlledSubareaIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 controlledSubareaIds[i] = reader.ReadVarUhShort();
            }
            leaderCharacterId = reader.ReadVarUhLong();
            leaderCharacterName = reader.ReadUTF();
            

}


}


}