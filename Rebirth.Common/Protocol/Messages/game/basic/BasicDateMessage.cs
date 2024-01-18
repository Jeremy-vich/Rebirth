


















// Generated on 01/30/2023 13:09:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BasicDateMessage : NetworkMessage
{

public const uint Id = 609;
public uint MessageId
{
    get { return Id; }
}

public sbyte day;
        public sbyte month;
        public short year;
        

public BasicDateMessage()
{
}

public BasicDateMessage(sbyte day, sbyte month, short year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(day);
            writer.WriteSbyte(month);
            writer.WriteShort(year);
            

}

public void Deserialize(IDataReader reader)
{

day = reader.ReadSbyte();
            month = reader.ReadSbyte();
            year = reader.ReadShort();
            

}


}


}