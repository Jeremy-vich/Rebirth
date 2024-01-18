


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class EnabledChannelsMessage : NetworkMessage
{

public const uint Id = 9386;
public uint MessageId
{
    get { return Id; }
}

public sbyte[] channels;
        public sbyte[] disallowed;
        

public EnabledChannelsMessage()
{
}

public EnabledChannelsMessage(sbyte[] channels, sbyte[] disallowed)
        {
            this.channels = channels;
            this.disallowed = disallowed;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)(ushort)channels.Length);
            foreach (var entry in channels)
            {
                 writer.WriteSbyte(entry);
            }
            writer.WriteVarInt((int)(ushort)disallowed.Length);
            foreach (var entry in disallowed)
            {
                 writer.WriteSbyte(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadVarInt();
            channels = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 channels[i] = reader.ReadSbyte();
            }
            limit = (ushort)reader.ReadVarInt();
            disallowed = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 disallowed[i] = reader.ReadSbyte();
            }
            

}


}


}