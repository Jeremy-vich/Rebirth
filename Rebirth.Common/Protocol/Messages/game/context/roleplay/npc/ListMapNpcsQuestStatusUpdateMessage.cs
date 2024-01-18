


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ListMapNpcsQuestStatusUpdateMessage : NetworkMessage
{

public const uint Id = 2320;
public uint MessageId
{
    get { return Id; }
}

public Types.MapNpcQuestInfo[] mapInfo;
        

public ListMapNpcsQuestStatusUpdateMessage()
{
}

public ListMapNpcsQuestStatusUpdateMessage(Types.MapNpcQuestInfo[] mapInfo)
        {
            this.mapInfo = mapInfo;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)mapInfo.Length);
            foreach (var entry in mapInfo)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            mapInfo = new Types.MapNpcQuestInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 mapInfo[i] = new Types.MapNpcQuestInfo();
                 mapInfo[i].Deserialize(reader);
            }
            

}


}


}