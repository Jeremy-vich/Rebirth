


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class HouseGuildedInformations : HouseInstanceInformations
{

public const short Id = 8503;
public override short TypeId
{
    get { return Id; }
}

public Types.GuildInformations guildInfo;
        

public HouseGuildedInformations()
{
}

public HouseGuildedInformations(bool secondHand, bool isLocked, bool hasOwner, bool isSaleLocked, bool isAdminLocked, int instanceId, Types.AccountTagInformation ownerTag, double price, Types.GuildInformations guildInfo)
         : base(secondHand, isLocked, hasOwner, isSaleLocked, isAdminLocked, instanceId, ownerTag, price)
        {
            this.guildInfo = guildInfo;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            guildInfo.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
            

}


}


}