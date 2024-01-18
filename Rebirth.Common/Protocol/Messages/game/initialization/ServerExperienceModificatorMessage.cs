


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ServerExperienceModificatorMessage : NetworkMessage
{

public const uint Id = 6426;
public uint MessageId
{
    get { return Id; }
}

public uint experiencePercent;
        

public ServerExperienceModificatorMessage()
{
}

public ServerExperienceModificatorMessage(uint experiencePercent)
        {
            this.experiencePercent = experiencePercent;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)experiencePercent);
            

}

public void Deserialize(IDataReader reader)
{

experiencePercent = reader.ReadVarUhShort();
            

}


}


}