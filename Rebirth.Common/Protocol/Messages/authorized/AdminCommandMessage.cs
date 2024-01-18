


















// Generated on 01/30/2023 13:09:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AdminCommandMessage : NetworkMessage
{

public const uint Id = 232;
public uint MessageId
{
    get { return Id; }
}

public string content;
        

public AdminCommandMessage()
{
}

public AdminCommandMessage(string content)
        {
            this.content = content;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(content);
            

}

public void Deserialize(IDataReader reader)
{

content = reader.ReadUTF();
            

}


}


}