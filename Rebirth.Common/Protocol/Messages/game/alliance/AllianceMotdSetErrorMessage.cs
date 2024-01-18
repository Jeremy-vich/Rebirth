


















// Generated on 01/30/2023 13:09:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceMotdSetErrorMessage : SocialNoticeSetErrorMessage
{

public const uint Id = 7772;
public uint MessageId
{
    get { return Id; }
}



public AllianceMotdSetErrorMessage()
{
}

public AllianceMotdSetErrorMessage(sbyte reason)
         : base(reason)
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