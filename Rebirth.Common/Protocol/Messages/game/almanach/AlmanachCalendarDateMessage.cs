


















// Generated on 01/30/2023 13:09:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AlmanachCalendarDateMessage : NetworkMessage
{

public const uint Id = 2378;
public uint MessageId
{
    get { return Id; }
}

public int date;
        

public AlmanachCalendarDateMessage()
{
}

public AlmanachCalendarDateMessage(int date)
        {
            this.date = date;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(date);
            

}

public void Deserialize(IDataReader reader)
{

date = reader.ReadInt();
            

}


}


}