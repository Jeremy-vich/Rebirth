


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GuildUnlockNewTabActivity : GuildLogbookEntryBasicInformation
{

public const short Id = 7590;
public override short TypeId
{
    get { return Id; }
}



public GuildUnlockNewTabActivity()
{
}

public GuildUnlockNewTabActivity(uint id, double date)
         : base(id, date)
        {
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}