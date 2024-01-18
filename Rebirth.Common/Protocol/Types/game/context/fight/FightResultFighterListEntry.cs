


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class FightResultFighterListEntry : FightResultListEntry
{

public const short Id = 8547;
public override short TypeId
{
    get { return Id; }
}

public double id;
        public bool alive;
        

public FightResultFighterListEntry()
{
}

public FightResultFighterListEntry(uint outcome, sbyte wave, Types.FightLoot rewards, double id, bool alive)
         : base(outcome, wave, rewards)
        {
            this.id = id;
            this.alive = alive;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(id);
            writer.WriteBoolean(alive);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            id = reader.ReadDouble();
            alive = reader.ReadBoolean();
            

}


}


}