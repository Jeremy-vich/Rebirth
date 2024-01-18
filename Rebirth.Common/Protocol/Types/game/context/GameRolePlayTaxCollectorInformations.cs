


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameRolePlayTaxCollectorInformations : GameRolePlayActorInformations
{

public const short Id = 7265;
public override short TypeId
{
    get { return Id; }
}

public Types.TaxCollectorStaticInformations identification;
        public byte guildLevel;
        public int taxCollectorAttack;
        

public GameRolePlayTaxCollectorInformations()
{
}

public GameRolePlayTaxCollectorInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, Types.TaxCollectorStaticInformations identification, byte guildLevel, int taxCollectorAttack)
         : base(contextualId, disposition, look)
        {
            this.identification = identification;
            this.guildLevel = guildLevel;
            this.taxCollectorAttack = taxCollectorAttack;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(identification.TypeId);
            identification.Serialize(writer);
            writer.WriteByte(guildLevel);
            writer.WriteInt(taxCollectorAttack);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            identification = ProtocolTypeManager.GetInstance<Types.TaxCollectorStaticInformations>(reader.ReadUShort());
            identification.Deserialize(reader);
            guildLevel = reader.ReadByte();
            taxCollectorAttack = reader.ReadInt();
            

}


}


}