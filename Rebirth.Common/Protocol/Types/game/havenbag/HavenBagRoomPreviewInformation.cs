


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class HavenBagRoomPreviewInformation
{

public const short Id = 4008;
public virtual short TypeId
{
    get { return Id; }
}

public byte roomId;
        public sbyte themeId;
        

public HavenBagRoomPreviewInformation()
{
}

public HavenBagRoomPreviewInformation(byte roomId, sbyte themeId)
        {
            this.roomId = roomId;
            this.themeId = themeId;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteByte(roomId);
            writer.WriteSbyte(themeId);
            

}

public virtual void Deserialize(IDataReader reader)
{

roomId = reader.ReadByte();
            themeId = reader.ReadSbyte();
            

}


}


}