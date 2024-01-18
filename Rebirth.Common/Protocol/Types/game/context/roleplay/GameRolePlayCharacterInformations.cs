


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameRolePlayCharacterInformations : GameRolePlayHumanoidInformations
{

public const short Id = 9999;
public override short TypeId
{
    get { return Id; }
}

public Types.ActorAlignmentInformations alignmentInfos;
        

public GameRolePlayCharacterInformations()
{
}

public GameRolePlayCharacterInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, string name, Types.HumanInformations humanoidInfo, int accountId, Types.ActorAlignmentInformations alignmentInfos)
         : base(contextualId, disposition, look, name, humanoidInfo, accountId)
        {
            this.alignmentInfos = alignmentInfos;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            alignmentInfos.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            alignmentInfos = new Types.ActorAlignmentInformations();
            alignmentInfos.Deserialize(reader);
            

}


}


}