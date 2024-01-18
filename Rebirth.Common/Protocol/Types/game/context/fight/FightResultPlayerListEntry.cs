


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class FightResultPlayerListEntry : FightResultFighterListEntry
{

public const short Id = 9016;
public override short TypeId
{
    get { return Id; }
}

public uint level;
        public Types.FightResultAdditionalData[] additional;
        

public FightResultPlayerListEntry()
{
}

public FightResultPlayerListEntry(uint outcome, sbyte wave, Types.FightLoot rewards, double id, bool alive, uint level, Types.FightResultAdditionalData[] additional)
         : base(outcome, wave, rewards, id, alive)
        {
            this.level = level;
            this.additional = additional;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)level);
            writer.WriteShort((short)additional.Length);
            foreach (var entry in additional)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            level = reader.ReadVarUhShort();
            var limit = (ushort)reader.ReadUShort();
            additional = new Types.FightResultAdditionalData[limit];
            for (int i = 0; i < limit; i++)
            {
                 additional[i] = ProtocolTypeManager.GetInstance<Types.FightResultAdditionalData>(reader.ReadUShort());
                 additional[i].Deserialize(reader);
            }
            

}


}


}