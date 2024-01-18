


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameRolePlayTreasureHintInformations : GameRolePlayActorInformations
{

public const short Id = 2825;
public override short TypeId
{
    get { return Id; }
}

public uint npcId;
        

public GameRolePlayTreasureHintInformations()
{
}

public GameRolePlayTreasureHintInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, uint npcId)
         : base(contextualId, disposition, look)
        {
            this.npcId = npcId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)npcId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            npcId = reader.ReadVarUhShort();
            

}


}


}