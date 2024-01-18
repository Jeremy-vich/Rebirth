


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ChatKolizeumServerMessage : ChatServerMessage
{

public const uint Id = 5686;
public uint MessageId
{
    get { return Id; }
}

public short originServerId;
        

public ChatKolizeumServerMessage()
{
}

public ChatKolizeumServerMessage(sbyte channel, string content, int timestamp, string fingerprint, double senderId, string senderName, string prefix, int senderAccountId, short originServerId)
         : base(channel, content, timestamp, fingerprint, senderId, senderName, prefix, senderAccountId)
        {
            this.originServerId = originServerId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(originServerId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            originServerId = reader.ReadShort();
            

}


}


}