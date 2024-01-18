


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameRolePlayMutantInformations : GameRolePlayHumanoidInformations
{

public const short Id = 3361;
public override short TypeId
{
    get { return Id; }
}

public uint monsterId;
        public sbyte powerLevel;
        

public GameRolePlayMutantInformations()
{
}

public GameRolePlayMutantInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, string name, Types.HumanInformations humanoidInfo, int accountId, uint monsterId, sbyte powerLevel)
         : base(contextualId, disposition, look, name, humanoidInfo, accountId)
        {
            this.monsterId = monsterId;
            this.powerLevel = powerLevel;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)monsterId);
            writer.WriteSbyte(powerLevel);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            monsterId = reader.ReadVarUhShort();
            powerLevel = reader.ReadSbyte();
            

}


}


}