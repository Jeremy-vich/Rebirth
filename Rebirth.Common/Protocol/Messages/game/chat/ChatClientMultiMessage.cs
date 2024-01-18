


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ChatClientMultiMessage : ChatAbstractClientMessage
{

public const uint Id = 4757;
public uint MessageId
{
    get { return Id; }
}

public sbyte channel;
        

public ChatClientMultiMessage()
{
}

public ChatClientMultiMessage(string content, sbyte channel)
         : base(content)
        {
            this.channel = channel;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(channel);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            channel = reader.ReadSbyte();
            

}


}


}