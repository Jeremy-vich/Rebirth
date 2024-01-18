


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ChatSmileyMessage : NetworkMessage
{

public const uint Id = 9057;
public uint MessageId
{
    get { return Id; }
}

public double entityId;
        public uint smileyId;
        public int accountId;
        

public ChatSmileyMessage()
{
}

public ChatSmileyMessage(double entityId, uint smileyId, int accountId)
        {
            this.entityId = entityId;
            this.smileyId = smileyId;
            this.accountId = accountId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(entityId);
            writer.WriteVarShort((int)smileyId);
            writer.WriteInt(accountId);
            

}

public void Deserialize(IDataReader reader)
{

entityId = reader.ReadDouble();
            smileyId = reader.ReadVarUhShort();
            accountId = reader.ReadInt();
            

}


}


}