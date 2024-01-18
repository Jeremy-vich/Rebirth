


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameRolePlayNpcWithQuestInformations : GameRolePlayNpcInformations
{

public const short Id = 7406;
public override short TypeId
{
    get { return Id; }
}

public Types.GameRolePlayNpcQuestFlag questFlag;
        

public GameRolePlayNpcWithQuestInformations()
{
}

public GameRolePlayNpcWithQuestInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, uint npcId, bool sex, uint specialArtworkId, Types.GameRolePlayNpcQuestFlag questFlag)
         : base(contextualId, disposition, look, npcId, sex, specialArtworkId)
        {
            this.questFlag = questFlag;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            questFlag.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            questFlag = new Types.GameRolePlayNpcQuestFlag();
            questFlag.Deserialize(reader);
            

}


}


}