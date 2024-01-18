


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GroupMonsterStaticInformationsWithAlternatives : GroupMonsterStaticInformations
{

public const short Id = 6494;
public override short TypeId
{
    get { return Id; }
}

public Types.AlternativeMonstersInGroupLightInformations[] alternatives;
        

public GroupMonsterStaticInformationsWithAlternatives()
{
}

public GroupMonsterStaticInformationsWithAlternatives(Types.MonsterInGroupLightInformations mainCreatureLightInfos, Types.MonsterInGroupInformations[] underlings, Types.AlternativeMonstersInGroupLightInformations[] alternatives)
         : base(mainCreatureLightInfos, underlings)
        {
            this.alternatives = alternatives;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)alternatives.Length);
            foreach (var entry in alternatives)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            alternatives = new Types.AlternativeMonstersInGroupLightInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 alternatives[i] = new Types.AlternativeMonstersInGroupLightInformations();
                 alternatives[i].Deserialize(reader);
            }
            

}


}


}