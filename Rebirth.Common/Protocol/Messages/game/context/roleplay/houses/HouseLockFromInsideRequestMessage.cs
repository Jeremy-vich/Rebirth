


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HouseLockFromInsideRequestMessage : LockableChangeCodeMessage
{

public const uint Id = 8494;
public uint MessageId
{
    get { return Id; }
}



public HouseLockFromInsideRequestMessage()
{
}

public HouseLockFromInsideRequestMessage(string code)
         : base(code)
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