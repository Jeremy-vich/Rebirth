


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AlignmentWarEffortDonateRequestMessage : NetworkMessage
{

public const uint Id = 742;
public uint MessageId
{
    get { return Id; }
}

public double donation;
        

public AlignmentWarEffortDonateRequestMessage()
{
}

public AlignmentWarEffortDonateRequestMessage(double donation)
        {
            this.donation = donation;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(donation);
            

}

public void Deserialize(IDataReader reader)
{

donation = reader.ReadVarUhLong();
            

}


}


}