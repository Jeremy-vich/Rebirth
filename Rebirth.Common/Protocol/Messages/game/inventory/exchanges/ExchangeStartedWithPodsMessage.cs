


















// Generated on 01/30/2023 13:09:25
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeStartedWithPodsMessage : ExchangeStartedMessage
{

public const uint Id = 6923;
public uint MessageId
{
    get { return Id; }
}

public double firstCharacterId;
        public uint firstCharacterCurrentWeight;
        public uint firstCharacterMaxWeight;
        public double secondCharacterId;
        public uint secondCharacterCurrentWeight;
        public uint secondCharacterMaxWeight;
        

public ExchangeStartedWithPodsMessage()
{
}

public ExchangeStartedWithPodsMessage(sbyte exchangeType, double firstCharacterId, uint firstCharacterCurrentWeight, uint firstCharacterMaxWeight, double secondCharacterId, uint secondCharacterCurrentWeight, uint secondCharacterMaxWeight)
         : base(exchangeType)
        {
            this.firstCharacterId = firstCharacterId;
            this.firstCharacterCurrentWeight = firstCharacterCurrentWeight;
            this.firstCharacterMaxWeight = firstCharacterMaxWeight;
            this.secondCharacterId = secondCharacterId;
            this.secondCharacterCurrentWeight = secondCharacterCurrentWeight;
            this.secondCharacterMaxWeight = secondCharacterMaxWeight;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(firstCharacterId);
            writer.WriteVarInt((int)firstCharacterCurrentWeight);
            writer.WriteVarInt((int)firstCharacterMaxWeight);
            writer.WriteDouble(secondCharacterId);
            writer.WriteVarInt((int)secondCharacterCurrentWeight);
            writer.WriteVarInt((int)secondCharacterMaxWeight);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            firstCharacterId = reader.ReadDouble();
            firstCharacterCurrentWeight = reader.ReadVarUhInt();
            firstCharacterMaxWeight = reader.ReadVarUhInt();
            secondCharacterId = reader.ReadDouble();
            secondCharacterCurrentWeight = reader.ReadVarUhInt();
            secondCharacterMaxWeight = reader.ReadVarUhInt();
            

}


}


}