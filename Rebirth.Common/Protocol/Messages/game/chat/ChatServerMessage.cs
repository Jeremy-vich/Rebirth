


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ChatServerMessage : ChatAbstractServerMessage
{

public const uint Id = 6743;
public uint MessageId
{
    get { return Id; }
}

public double senderId;
        public string senderName;
        public string prefix;
        public int senderAccountId;
        

public ChatServerMessage()
{
}

public ChatServerMessage(sbyte channel, string content, int timestamp, string fingerprint, double senderId, string senderName, string prefix, int senderAccountId)
         : base(channel, content, timestamp, fingerprint)
        {
            this.senderId = senderId;
            this.senderName = senderName;
            this.prefix = prefix;
            this.senderAccountId = senderAccountId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(senderId);
            writer.WriteUTF(senderName);
            writer.WriteUTF(prefix);
            writer.WriteInt(senderAccountId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            senderId = reader.ReadDouble();
            senderName = reader.ReadUTF();
            prefix = reader.ReadUTF();
            senderAccountId = reader.ReadInt();
            

}


}


}