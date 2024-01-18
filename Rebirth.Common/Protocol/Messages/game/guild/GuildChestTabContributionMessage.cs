


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildChestTabContributionMessage : NetworkMessage
{

public const uint Id = 5407;
public uint MessageId
{
    get { return Id; }
}

public uint tabNumber;
        public double requiredAmount;
        public double currentAmount;
        public double chestContributionEnrollmentDelay;
        public double chestContributionDelay;
        

public GuildChestTabContributionMessage()
{
}

public GuildChestTabContributionMessage(uint tabNumber, double requiredAmount, double currentAmount, double chestContributionEnrollmentDelay, double chestContributionDelay)
        {
            this.tabNumber = tabNumber;
            this.requiredAmount = requiredAmount;
            this.currentAmount = currentAmount;
            this.chestContributionEnrollmentDelay = chestContributionEnrollmentDelay;
            this.chestContributionDelay = chestContributionDelay;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)tabNumber);
            writer.WriteVarLong(requiredAmount);
            writer.WriteVarLong(currentAmount);
            writer.WriteDouble(chestContributionEnrollmentDelay);
            writer.WriteDouble(chestContributionDelay);
            

}

public void Deserialize(IDataReader reader)
{

tabNumber = reader.ReadVarUhInt();
            requiredAmount = reader.ReadVarUhLong();
            currentAmount = reader.ReadVarUhLong();
            chestContributionEnrollmentDelay = reader.ReadDouble();
            chestContributionDelay = reader.ReadDouble();
            

}


}


}