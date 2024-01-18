


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HaapiConfirmationRequestMessage : NetworkMessage
{

public const uint Id = 8461;
public uint MessageId
{
    get { return Id; }
}

public double kamas;
        public double ogrines;
        public uint rate;
        public sbyte action;
        

public HaapiConfirmationRequestMessage()
{
}

public HaapiConfirmationRequestMessage(double kamas, double ogrines, uint rate, sbyte action)
        {
            this.kamas = kamas;
            this.ogrines = ogrines;
            this.rate = rate;
            this.action = action;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(kamas);
            writer.WriteVarLong(ogrines);
            writer.WriteVarShort((int)rate);
            writer.WriteSbyte(action);
            

}

public void Deserialize(IDataReader reader)
{

kamas = reader.ReadVarUhLong();
            ogrines = reader.ReadVarUhLong();
            rate = reader.ReadVarUhShort();
            action = reader.ReadSbyte();
            

}


}


}