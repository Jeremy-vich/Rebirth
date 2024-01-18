


















// Generated on 01/30/2023 13:09:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ConsoleMessage : NetworkMessage
{

public const uint Id = 6197;
public uint MessageId
{
    get { return Id; }
}

public sbyte type;
        public string content;
        

public ConsoleMessage()
{
}

public ConsoleMessage(sbyte type, string content)
        {
            this.type = type;
            this.content = content;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(type);
            writer.WriteUTF(content);
            

}

public void Deserialize(IDataReader reader)
{

type = reader.ReadSbyte();
            content = reader.ReadUTF();
            

}


}


}