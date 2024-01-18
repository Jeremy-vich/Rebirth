


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HavenBagDailyLoteryMessage : NetworkMessage
{

public const uint Id = 3458;
public uint MessageId
{
    get { return Id; }
}

public string gameActionId;
        

public HavenBagDailyLoteryMessage()
{
}

public HavenBagDailyLoteryMessage(string gameActionId)
        {
            this.gameActionId = gameActionId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(gameActionId);
            

}

public void Deserialize(IDataReader reader)
{

gameActionId = reader.ReadUTF();
            

}


}


}