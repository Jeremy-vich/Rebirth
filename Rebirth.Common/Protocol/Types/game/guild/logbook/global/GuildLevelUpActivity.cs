


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GuildLevelUpActivity : GuildLogbookEntryBasicInformation
{

public const short Id = 118;
public override short TypeId
{
    get { return Id; }
}

public byte newGuildLevel;
        

public GuildLevelUpActivity()
{
}

public GuildLevelUpActivity(uint id, double date, byte newGuildLevel)
         : base(id, date)
        {
            this.newGuildLevel = newGuildLevel;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteByte(newGuildLevel);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            newGuildLevel = reader.ReadByte();
            

}


}


}