


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ProtocolRequired : NetworkMessage
{

public const uint Id = 6212;
public uint MessageId
{
    get { return Id; }
}

public string version;
        

public ProtocolRequired()
{
}

public ProtocolRequired(string version)
        {
            this.version = version;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(version);
            

}

public void Deserialize(IDataReader reader)
{

version = reader.ReadUTF();
            

}


}


}