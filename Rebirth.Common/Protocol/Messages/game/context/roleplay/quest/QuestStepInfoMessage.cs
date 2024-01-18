


















// Generated on 01/30/2023 13:09:19
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class QuestStepInfoMessage : NetworkMessage
{

public const uint Id = 4313;
public uint MessageId
{
    get { return Id; }
}

public Types.QuestActiveInformations infos;
        

public QuestStepInfoMessage()
{
}

public QuestStepInfoMessage(Types.QuestActiveInformations infos)
        {
            this.infos = infos;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(infos.TypeId);
            infos.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

infos = ProtocolTypeManager.GetInstance<Types.QuestActiveInformations>(reader.ReadUShort());
            infos.Deserialize(reader);
            

}


}


}