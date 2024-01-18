


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class IgnoredDeleteRequestMessage : NetworkMessage
{

public const uint Id = 7964;
public uint MessageId
{
    get { return Id; }
}

public int accountId;
        public bool session;
        

public IgnoredDeleteRequestMessage()
{
}

public IgnoredDeleteRequestMessage(int accountId, bool session)
        {
            this.accountId = accountId;
            this.session = session;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(accountId);
            writer.WriteBoolean(session);
            

}

public void Deserialize(IDataReader reader)
{

accountId = reader.ReadInt();
            session = reader.ReadBoolean();
            

}


}


}