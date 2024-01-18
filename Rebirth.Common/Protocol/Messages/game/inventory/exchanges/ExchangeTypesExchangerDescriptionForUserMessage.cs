


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeTypesExchangerDescriptionForUserMessage : NetworkMessage
{

public const uint Id = 473;
public uint MessageId
{
    get { return Id; }
}

public int objectType;
        public uint[] typeDescription;
        

public ExchangeTypesExchangerDescriptionForUserMessage()
{
}

public ExchangeTypesExchangerDescriptionForUserMessage(int objectType, uint[] typeDescription)
        {
            this.objectType = objectType;
            this.typeDescription = typeDescription;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(objectType);
            writer.WriteShort((short)typeDescription.Length);
            foreach (var entry in typeDescription)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

objectType = reader.ReadInt();
            var limit = (ushort)reader.ReadUShort();
            typeDescription = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 typeDescription[i] = reader.ReadVarUhInt();
            }
            

}


}


}