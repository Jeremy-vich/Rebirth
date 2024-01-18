


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HavenBagRoomUpdateMessage : NetworkMessage
{

public const uint Id = 9197;
public uint MessageId
{
    get { return Id; }
}

public sbyte action;
        public Types.HavenBagRoomPreviewInformation[] roomsPreview;
        

public HavenBagRoomUpdateMessage()
{
}

public HavenBagRoomUpdateMessage(sbyte action, Types.HavenBagRoomPreviewInformation[] roomsPreview)
        {
            this.action = action;
            this.roomsPreview = roomsPreview;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(action);
            writer.WriteShort((short)roomsPreview.Length);
            foreach (var entry in roomsPreview)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

action = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            roomsPreview = new Types.HavenBagRoomPreviewInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 roomsPreview[i] = new Types.HavenBagRoomPreviewInformation();
                 roomsPreview[i].Deserialize(reader);
            }
            

}


}


}