


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class AbstractContactInformations
{

public const short Id = 2855;
public virtual short TypeId
{
    get { return Id; }
}

public int accountId;
        public Types.AccountTagInformation accountTag;
        

public AbstractContactInformations()
{
}

public AbstractContactInformations(int accountId, Types.AccountTagInformation accountTag)
        {
            this.accountId = accountId;
            this.accountTag = accountTag;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(accountId);
            accountTag.Serialize(writer);
            

}

public virtual void Deserialize(IDataReader reader)
{

accountId = reader.ReadInt();
            accountTag = new Types.AccountTagInformation();
            accountTag.Deserialize(reader);
            

}


}


}