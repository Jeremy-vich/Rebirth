


















// Generated on 01/30/2023 13:09:25
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeOnHumanVendorRequestMessage : NetworkMessage
{

public const uint Id = 5497;
public uint MessageId
{
    get { return Id; }
}

public double humanVendorId;
        public uint humanVendorCell;
        

public ExchangeOnHumanVendorRequestMessage()
{
}

public ExchangeOnHumanVendorRequestMessage(double humanVendorId, uint humanVendorCell)
        {
            this.humanVendorId = humanVendorId;
            this.humanVendorCell = humanVendorCell;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(humanVendorId);
            writer.WriteVarShort((int)humanVendorCell);
            

}

public void Deserialize(IDataReader reader)
{

humanVendorId = reader.ReadVarUhLong();
            humanVendorCell = reader.ReadVarUhShort();
            

}


}


}