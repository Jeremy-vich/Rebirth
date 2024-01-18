


















// Generated on 01/30/2023 13:09:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BasicStatWithDataMessage : BasicStatMessage
{

public const uint Id = 3426;
public uint MessageId
{
    get { return Id; }
}

public Types.StatisticData[] datas;
        

public BasicStatWithDataMessage()
{
}

public BasicStatWithDataMessage(double timeSpent, uint statId, Types.StatisticData[] datas)
         : base(timeSpent, statId)
        {
            this.datas = datas;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)datas.Length);
            foreach (var entry in datas)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            datas = new Types.StatisticData[limit];
            for (int i = 0; i < limit; i++)
            {
                 datas[i] = ProtocolTypeManager.GetInstance<Types.StatisticData>(reader.ReadUShort());
                 datas[i].Deserialize(reader);
            }
            

}


}


}