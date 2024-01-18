


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ChatServerCopyMessage : ChatAbstractServerMessage
{

public const uint Id = 9262;
public uint MessageId
{
    get { return Id; }
}

public double receiverId;
        public string receiverName;
        

public ChatServerCopyMessage()
{
}

public ChatServerCopyMessage(sbyte channel, string content, int timestamp, string fingerprint, double receiverId, string receiverName)
         : base(channel, content, timestamp, fingerprint)
        {
            this.receiverId = receiverId;
            this.receiverName = receiverName;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(receiverId);
            writer.WriteUTF(receiverName);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            receiverId = reader.ReadVarUhLong();
            receiverName = reader.ReadUTF();
            

}


}


}