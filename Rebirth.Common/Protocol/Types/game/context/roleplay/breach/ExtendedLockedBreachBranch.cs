


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ExtendedLockedBreachBranch : ExtendedBreachBranch
{

public const short Id = 7105;
public override short TypeId
{
    get { return Id; }
}

public uint unlockPrice;
        

public ExtendedLockedBreachBranch()
{
}

public ExtendedLockedBreachBranch(sbyte room, int element, Types.MonsterInGroupLightInformations[] bosses, double map, short score, short relativeScore, Types.MonsterInGroupLightInformations[] monsters, Types.BreachReward[] rewards, int modifier, uint prize, uint unlockPrice)
         : base(room, element, bosses, map, score, relativeScore, monsters, rewards, modifier, prize)
        {
            this.unlockPrice = unlockPrice;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)unlockPrice);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            unlockPrice = reader.ReadVarUhInt();
            

}


}


}