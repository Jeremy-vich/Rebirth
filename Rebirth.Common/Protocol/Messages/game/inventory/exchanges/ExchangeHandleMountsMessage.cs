


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeHandleMountsMessage : NetworkMessage
{

public const uint Id = 3191;
public uint MessageId
{
    get { return Id; }
}

public sbyte actionType;
        public uint[] ridesId;
        

public ExchangeHandleMountsMessage()
{
}

public ExchangeHandleMountsMessage(sbyte actionType, uint[] ridesId)
        {
            this.actionType = actionType;
            this.ridesId = ridesId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(actionType);
            writer.WriteShort((short)ridesId.Length);
            foreach (var entry in ridesId)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

actionType = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            ridesId = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 ridesId[i] = reader.ReadVarUhInt();
            }
            

}


}


}