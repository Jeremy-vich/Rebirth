


















// Generated on 01/30/2023 13:09:25
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeObjectTransfertListWithQuantityToInvMessage : NetworkMessage
{

public const uint Id = 9696;
public uint MessageId
{
    get { return Id; }
}

public uint[] ids;
        public uint[] qtys;
        

public ExchangeObjectTransfertListWithQuantityToInvMessage()
{
}

public ExchangeObjectTransfertListWithQuantityToInvMessage(uint[] ids, uint[] qtys)
        {
            this.ids = ids;
            this.qtys = qtys;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)ids.Length);
            foreach (var entry in ids)
            {
                 writer.WriteVarInt((int)entry);
            }
            writer.WriteShort((short)qtys.Length);
            foreach (var entry in qtys)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            ids = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 ids[i] = reader.ReadVarUhInt();
            }
            limit = (ushort)reader.ReadUShort();
            qtys = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 qtys[i] = reader.ReadVarUhInt();
            }
            

}


}


}