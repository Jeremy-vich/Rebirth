


















// Generated on 01/30/2023 13:09:19
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class WatchQuestStepInfoMessage : QuestStepInfoMessage
{

public const uint Id = 673;
public uint MessageId
{
    get { return Id; }
}

public double playerId;
        

public WatchQuestStepInfoMessage()
{
}

public WatchQuestStepInfoMessage(Types.QuestActiveInformations infos, double playerId)
         : base(infos)
        {
            this.playerId = playerId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(playerId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            

}


}


}