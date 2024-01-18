


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class LockableChangeCodeMessage : NetworkMessage
{

public const uint Id = 5435;
public uint MessageId
{
    get { return Id; }
}

public string code;
        

public LockableChangeCodeMessage()
{
}

public LockableChangeCodeMessage(string code)
        {
            this.code = code;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(code);
            

}

public void Deserialize(IDataReader reader)
{

code = reader.ReadUTF();
            

}


}


}