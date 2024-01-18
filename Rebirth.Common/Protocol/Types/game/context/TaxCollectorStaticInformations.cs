


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class TaxCollectorStaticInformations
{

public const short Id = 4346;
public virtual short TypeId
{
    get { return Id; }
}

public uint firstNameId;
        public uint lastNameId;
        public Types.GuildInformations guildIdentity;
        public double callerId;
        

public TaxCollectorStaticInformations()
{
}

public TaxCollectorStaticInformations(uint firstNameId, uint lastNameId, Types.GuildInformations guildIdentity, double callerId)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
            this.guildIdentity = guildIdentity;
            this.callerId = callerId;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)firstNameId);
            writer.WriteVarShort((int)lastNameId);
            guildIdentity.Serialize(writer);
            writer.WriteVarLong(callerId);
            

}

public virtual void Deserialize(IDataReader reader)
{

firstNameId = reader.ReadVarUhShort();
            lastNameId = reader.ReadVarUhShort();
            guildIdentity = new Types.GuildInformations();
            guildIdentity.Deserialize(reader);
            callerId = reader.ReadVarUhLong();
            

}


}


}