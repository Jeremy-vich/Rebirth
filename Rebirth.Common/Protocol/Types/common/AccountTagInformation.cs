


















// Generated on 01/30/2023 13:09:30
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class AccountTagInformation
{

public const short Id = 4213;
public virtual short TypeId
{
    get { return Id; }
}

public string nickname;
        public string tagNumber;
        

public AccountTagInformation()
{
}

public AccountTagInformation(string nickname, string tagNumber)
        {
            this.nickname = nickname;
            this.tagNumber = tagNumber;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteUTF(nickname);
            writer.WriteUTF(tagNumber);
            

}

public virtual void Deserialize(IDataReader reader)
{

nickname = reader.ReadUTF();
            tagNumber = reader.ReadUTF();
            

}


}


}