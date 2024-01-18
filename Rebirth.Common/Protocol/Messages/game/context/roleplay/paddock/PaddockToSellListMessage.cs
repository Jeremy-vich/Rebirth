


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PaddockToSellListMessage : NetworkMessage
{

public const uint Id = 505;
public uint MessageId
{
    get { return Id; }
}

public uint pageIndex;
        public uint totalPage;
        public Types.PaddockInformationsForSell[] paddockList;
        

public PaddockToSellListMessage()
{
}

public PaddockToSellListMessage(uint pageIndex, uint totalPage, Types.PaddockInformationsForSell[] paddockList)
        {
            this.pageIndex = pageIndex;
            this.totalPage = totalPage;
            this.paddockList = paddockList;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)pageIndex);
            writer.WriteVarShort((int)totalPage);
            writer.WriteShort((short)paddockList.Length);
            foreach (var entry in paddockList)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

pageIndex = reader.ReadVarUhShort();
            totalPage = reader.ReadVarUhShort();
            var limit = (ushort)reader.ReadUShort();
            paddockList = new Types.PaddockInformationsForSell[limit];
            for (int i = 0; i < limit; i++)
            {
                 paddockList[i] = new Types.PaddockInformationsForSell();
                 paddockList[i].Deserialize(reader);
            }
            

}


}


}