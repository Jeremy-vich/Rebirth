


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class EmotePlayMessage : EmotePlayAbstractMessage
{

public const uint Id = 4251;
public uint MessageId
{
    get { return Id; }
}

public double actorId;
        public int accountId;
        

public EmotePlayMessage()
{
}

public EmotePlayMessage(ushort emoteId, double emoteStartTime, double actorId, int accountId)
         : base(emoteId, emoteStartTime)
        {
            this.actorId = actorId;
            this.accountId = accountId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(actorId);
            writer.WriteInt(accountId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            actorId = reader.ReadDouble();
            accountId = reader.ReadInt();
            

}


}


}