


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PopupWarningMessage : NetworkMessage
{

public const uint Id = 4137;
public uint MessageId
{
    get { return Id; }
}

public byte lockDuration;
        public string author;
        public string content;
        

public PopupWarningMessage()
{
}

public PopupWarningMessage(byte lockDuration, string author, string content)
        {
            this.lockDuration = lockDuration;
            this.author = author;
            this.content = content;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteByte(lockDuration);
            writer.WriteUTF(author);
            writer.WriteUTF(content);
            

}

public void Deserialize(IDataReader reader)
{

lockDuration = reader.ReadByte();
            author = reader.ReadUTF();
            content = reader.ReadUTF();
            

}


}


}