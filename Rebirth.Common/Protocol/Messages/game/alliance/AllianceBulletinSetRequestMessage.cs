


















// Generated on 01/30/2023 13:09:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceBulletinSetRequestMessage : SocialNoticeSetRequestMessage
{

public const uint Id = 3780;
public uint MessageId
{
    get { return Id; }
}

public string content;
        public bool notifyMembers;
        

public AllianceBulletinSetRequestMessage()
{
}

public AllianceBulletinSetRequestMessage(string content, bool notifyMembers)
        {
            this.content = content;
            this.notifyMembers = notifyMembers;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(content);
            writer.WriteBoolean(notifyMembers);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            content = reader.ReadUTF();
            notifyMembers = reader.ReadBoolean();
            

}


}


}