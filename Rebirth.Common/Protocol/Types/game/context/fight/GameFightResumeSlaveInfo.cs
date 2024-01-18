


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameFightResumeSlaveInfo
{

public const short Id = 149;
public virtual short TypeId
{
    get { return Id; }
}

public double slaveId;
        public Types.GameFightSpellCooldown[] spellCooldowns;
        public sbyte summonCount;
        public sbyte bombCount;
        

public GameFightResumeSlaveInfo()
{
}

public GameFightResumeSlaveInfo(double slaveId, Types.GameFightSpellCooldown[] spellCooldowns, sbyte summonCount, sbyte bombCount)
        {
            this.slaveId = slaveId;
            this.spellCooldowns = spellCooldowns;
            this.summonCount = summonCount;
            this.bombCount = bombCount;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteDouble(slaveId);
            writer.WriteShort((short)spellCooldowns.Length);
            foreach (var entry in spellCooldowns)
            {
                 entry.Serialize(writer);
            }
            writer.WriteSbyte(summonCount);
            writer.WriteSbyte(bombCount);
            

}

public virtual void Deserialize(IDataReader reader)
{

slaveId = reader.ReadDouble();
            var limit = (ushort)reader.ReadUShort();
            spellCooldowns = new Types.GameFightSpellCooldown[limit];
            for (int i = 0; i < limit; i++)
            {
                 spellCooldowns[i] = new Types.GameFightSpellCooldown();
                 spellCooldowns[i].Deserialize(reader);
            }
            summonCount = reader.ReadSbyte();
            bombCount = reader.ReadSbyte();
            

}


}


}