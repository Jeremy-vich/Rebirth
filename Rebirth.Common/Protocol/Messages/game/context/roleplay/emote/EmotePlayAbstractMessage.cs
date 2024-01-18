


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class EmotePlayAbstractMessage : NetworkMessage
{

public const uint Id = 1886;
public uint MessageId
{
    get { return Id; }
}

public ushort emoteId;
        public double emoteStartTime;
        

public EmotePlayAbstractMessage()
{
}

public EmotePlayAbstractMessage(ushort emoteId, double emoteStartTime)
        {
            this.emoteId = emoteId;
            this.emoteStartTime = emoteStartTime;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort(emoteId);
            writer.WriteDouble(emoteStartTime);
            

}

public void Deserialize(IDataReader reader)
{

emoteId = reader.ReadUShort();
            emoteStartTime = reader.ReadDouble();
            

}


}


}