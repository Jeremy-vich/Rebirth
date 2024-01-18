


















// Generated on 01/30/2023 13:09:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AccountLoggingKickedMessage : NetworkMessage
{

public const uint Id = 6526;
public uint MessageId
{
    get { return Id; }
}

public uint days;
        public sbyte hours;
        public sbyte minutes;
        

public AccountLoggingKickedMessage()
{
}

public AccountLoggingKickedMessage(uint days, sbyte hours, sbyte minutes)
        {
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)days);
            writer.WriteSbyte(hours);
            writer.WriteSbyte(minutes);
            

}

public void Deserialize(IDataReader reader)
{

days = reader.ReadVarUhShort();
            hours = reader.ReadSbyte();
            minutes = reader.ReadSbyte();
            

}


}


}