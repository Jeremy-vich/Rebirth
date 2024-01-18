


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AlignmentWarEffortDonationResultMessage : NetworkMessage
{

public const uint Id = 3978;
public uint MessageId
{
    get { return Id; }
}

public sbyte result;
        

public AlignmentWarEffortDonationResultMessage()
{
}

public AlignmentWarEffortDonationResultMessage(sbyte result)
        {
            this.result = result;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(result);
            

}

public void Deserialize(IDataReader reader)
{

result = reader.ReadSbyte();
            

}


}


}