


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameRolePlayHumanoidInformations : GameRolePlayNamedActorInformations
{

public const short Id = 2890;
public override short TypeId
{
    get { return Id; }
}

public Types.HumanInformations humanoidInfo;
        public int accountId;
        

public GameRolePlayHumanoidInformations()
{
}

public GameRolePlayHumanoidInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, string name, Types.HumanInformations humanoidInfo, int accountId)
         : base(contextualId, disposition, look, name)
        {
            this.humanoidInfo = humanoidInfo;
            this.accountId = accountId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(humanoidInfo.TypeId);
            humanoidInfo.Serialize(writer);
            writer.WriteInt(accountId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            humanoidInfo = ProtocolTypeManager.GetInstance<Types.HumanInformations>(reader.ReadUShort());
            humanoidInfo.Deserialize(reader);
            accountId = reader.ReadInt();
            

}


}


}