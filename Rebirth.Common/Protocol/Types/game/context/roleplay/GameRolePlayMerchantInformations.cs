


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameRolePlayMerchantInformations : GameRolePlayNamedActorInformations
{

public const short Id = 3744;
public override short TypeId
{
    get { return Id; }
}

public sbyte sellType;
        public Types.HumanOption[] options;
        

public GameRolePlayMerchantInformations()
{
}

public GameRolePlayMerchantInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, string name, sbyte sellType, Types.HumanOption[] options)
         : base(contextualId, disposition, look, name)
        {
            this.sellType = sellType;
            this.options = options;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(sellType);
            writer.WriteShort((short)options.Length);
            foreach (var entry in options)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            sellType = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            options = new Types.HumanOption[limit];
            for (int i = 0; i < limit; i++)
            {
                 options[i] = ProtocolTypeManager.GetInstance<Types.HumanOption>(reader.ReadUShort());
                 options[i].Deserialize(reader);
            }
            

}


}


}