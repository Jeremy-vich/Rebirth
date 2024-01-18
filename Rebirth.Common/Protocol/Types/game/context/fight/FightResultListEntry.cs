


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class FightResultListEntry
{

public const short Id = 676;
public virtual short TypeId
{
    get { return Id; }
}

public uint outcome;
        public sbyte wave;
        public Types.FightLoot rewards;
        

public FightResultListEntry()
{
}

public FightResultListEntry(uint outcome, sbyte wave, Types.FightLoot rewards)
        {
            this.outcome = outcome;
            this.wave = wave;
            this.rewards = rewards;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)outcome);
            writer.WriteSbyte(wave);
            rewards.Serialize(writer);
            

}

public virtual void Deserialize(IDataReader reader)
{

outcome = reader.ReadVarUhShort();
            wave = reader.ReadSbyte();
            rewards = new Types.FightLoot();
            rewards.Deserialize(reader);
            

}


}


}