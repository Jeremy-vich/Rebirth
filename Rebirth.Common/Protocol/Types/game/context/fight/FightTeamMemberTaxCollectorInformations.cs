


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class FightTeamMemberTaxCollectorInformations : FightTeamMemberInformations
{

public const short Id = 8225;
public override short TypeId
{
    get { return Id; }
}

public uint firstNameId;
        public uint lastNameId;
        public byte level;
        public uint guildId;
        public double uid;
        

public FightTeamMemberTaxCollectorInformations()
{
}

public FightTeamMemberTaxCollectorInformations(double id, uint firstNameId, uint lastNameId, byte level, uint guildId, double uid)
         : base(id)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
            this.level = level;
            this.guildId = guildId;
            this.uid = uid;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)firstNameId);
            writer.WriteVarShort((int)lastNameId);
            writer.WriteByte(level);
            writer.WriteVarInt((int)guildId);
            writer.WriteDouble(uid);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            firstNameId = reader.ReadVarUhShort();
            lastNameId = reader.ReadVarUhShort();
            level = reader.ReadByte();
            guildId = reader.ReadVarUhInt();
            uid = reader.ReadDouble();
            

}


}


}