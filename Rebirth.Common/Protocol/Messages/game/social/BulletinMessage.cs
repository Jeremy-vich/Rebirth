


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BulletinMessage : SocialNoticeMessage
{

public const uint Id = 3789;
public uint MessageId
{
    get { return Id; }
}

public int lastNotifiedTimestamp;
        

public BulletinMessage()
{
}

public BulletinMessage(string content, int timestamp, double memberId, string memberName, int lastNotifiedTimestamp)
         : base(content, timestamp, memberId, memberName)
        {
            this.lastNotifiedTimestamp = lastNotifiedTimestamp;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(lastNotifiedTimestamp);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            lastNotifiedTimestamp = reader.ReadInt();
            

}


}


}