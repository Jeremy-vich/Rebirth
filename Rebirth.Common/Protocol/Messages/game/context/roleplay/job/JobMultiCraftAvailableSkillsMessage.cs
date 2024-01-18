


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class JobMultiCraftAvailableSkillsMessage : JobAllowMultiCraftRequestMessage
{

public const uint Id = 3080;
public uint MessageId
{
    get { return Id; }
}

public double playerId;
        public uint[] skills;
        

public JobMultiCraftAvailableSkillsMessage()
{
}

public JobMultiCraftAvailableSkillsMessage(bool enabled, double playerId, uint[] skills)
         : base(enabled)
        {
            this.playerId = playerId;
            this.skills = skills;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(playerId);
            writer.WriteShort((short)skills.Length);
            foreach (var entry in skills)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            var limit = (ushort)reader.ReadUShort();
            skills = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 skills[i] = reader.ReadVarUhShort();
            }
            

}


}


}