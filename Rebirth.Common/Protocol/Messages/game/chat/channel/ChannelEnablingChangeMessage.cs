


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ChannelEnablingChangeMessage : NetworkMessage
{

public const uint Id = 2300;
public uint MessageId
{
    get { return Id; }
}

public sbyte channel;
        public bool enable;
        

public ChannelEnablingChangeMessage()
{
}

public ChannelEnablingChangeMessage(sbyte channel, bool enable)
        {
            this.channel = channel;
            this.enable = enable;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(channel);
            writer.WriteBoolean(enable);
            

}

public void Deserialize(IDataReader reader)
{

channel = reader.ReadSbyte();
            enable = reader.ReadBoolean();
            

}


}


}