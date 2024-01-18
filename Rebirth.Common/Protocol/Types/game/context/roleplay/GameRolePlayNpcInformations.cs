


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameRolePlayNpcInformations : GameRolePlayActorInformations
{

public const short Id = 1079;
public override short TypeId
{
    get { return Id; }
}

public uint npcId;
        public bool sex;
        public uint specialArtworkId;
        

public GameRolePlayNpcInformations()
{
}

public GameRolePlayNpcInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, uint npcId, bool sex, uint specialArtworkId)
         : base(contextualId, disposition, look)
        {
            this.npcId = npcId;
            this.sex = sex;
            this.specialArtworkId = specialArtworkId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)npcId);
            writer.WriteBoolean(sex);
            writer.WriteVarShort((int)specialArtworkId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            npcId = reader.ReadVarUhShort();
            sex = reader.ReadBoolean();
            specialArtworkId = reader.ReadVarUhShort();
            

}


}


}