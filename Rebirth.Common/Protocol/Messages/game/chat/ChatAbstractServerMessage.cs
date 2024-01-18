


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ChatAbstractServerMessage : NetworkMessage
{

public const uint Id = 4957;
public uint MessageId
{
    get { return Id; }
}

public sbyte channel;
        public string content;
        public int timestamp;
        public string fingerprint;
        

public ChatAbstractServerMessage()
{
}

public ChatAbstractServerMessage(sbyte channel, string content, int timestamp, string fingerprint)
        {
            this.channel = channel;
            this.content = content;
            this.timestamp = timestamp;
            this.fingerprint = fingerprint;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(channel);
            writer.WriteUTF(content);
            writer.WriteInt(timestamp);
            writer.WriteUTF(fingerprint);
            

}

public void Deserialize(IDataReader reader)
{

channel = reader.ReadSbyte();
            content = reader.ReadUTF();
            timestamp = reader.ReadInt();
            fingerprint = reader.ReadUTF();
            

}


}


}