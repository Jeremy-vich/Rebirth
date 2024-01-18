


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CharacterAlignmentWarEffortProgressionMessage : NetworkMessage
{

public const uint Id = 7285;
public uint MessageId
{
    get { return Id; }
}

public double alignmentWarEffortDailyLimit;
        public double alignmentWarEffortDailyDonation;
        public double alignmentWarEffortPersonalDonation;
        

public CharacterAlignmentWarEffortProgressionMessage()
{
}

public CharacterAlignmentWarEffortProgressionMessage(double alignmentWarEffortDailyLimit, double alignmentWarEffortDailyDonation, double alignmentWarEffortPersonalDonation)
        {
            this.alignmentWarEffortDailyLimit = alignmentWarEffortDailyLimit;
            this.alignmentWarEffortDailyDonation = alignmentWarEffortDailyDonation;
            this.alignmentWarEffortPersonalDonation = alignmentWarEffortPersonalDonation;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(alignmentWarEffortDailyLimit);
            writer.WriteVarLong(alignmentWarEffortDailyDonation);
            writer.WriteVarLong(alignmentWarEffortPersonalDonation);
            

}

public void Deserialize(IDataReader reader)
{

alignmentWarEffortDailyLimit = reader.ReadVarUhLong();
            alignmentWarEffortDailyDonation = reader.ReadVarUhLong();
            alignmentWarEffortPersonalDonation = reader.ReadVarUhLong();
            

}


}


}