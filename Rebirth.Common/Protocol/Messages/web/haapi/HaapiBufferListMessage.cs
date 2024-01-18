


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HaapiBufferListMessage : NetworkMessage
{

public const uint Id = 3697;
public uint MessageId
{
    get { return Id; }
}

public Types.BufferInformation[] buffers;
        

public HaapiBufferListMessage()
{
}

public HaapiBufferListMessage(Types.BufferInformation[] buffers)
        {
            this.buffers = buffers;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)buffers.Length);
            foreach (var entry in buffers)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            buffers = new Types.BufferInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 buffers[i] = new Types.BufferInformation();
                 buffers[i].Deserialize(reader);
            }
            

}


}


}