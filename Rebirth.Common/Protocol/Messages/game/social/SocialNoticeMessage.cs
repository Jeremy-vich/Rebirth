


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class SocialNoticeMessage : NetworkMessage
{

public const uint Id = 3981;
public uint MessageId
{
    get { return Id; }
}

public string content;
        public int timestamp;
        public double memberId;
        public string memberName;
        

public SocialNoticeMessage()
{
}

public SocialNoticeMessage(string content, int timestamp, double memberId, string memberName)
        {
            this.content = content;
            this.timestamp = timestamp;
            this.memberId = memberId;
            this.memberName = memberName;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(content);
            writer.WriteInt(timestamp);
            writer.WriteVarLong(memberId);
            writer.WriteUTF(memberName);
            

}

public void Deserialize(IDataReader reader)
{

content = reader.ReadUTF();
            timestamp = reader.ReadInt();
            memberId = reader.ReadVarUhLong();
            memberName = reader.ReadUTF();
            

}


}


}