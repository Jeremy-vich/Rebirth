


















// Generated on 01/30/2023 13:09:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ReloginTokenStatusMessage : NetworkMessage
{

public const uint Id = 4736;
public uint MessageId
{
    get { return Id; }
}

public bool validToken;
        public string token;
        

public ReloginTokenStatusMessage()
{
}

public ReloginTokenStatusMessage(bool validToken, string token)
        {
            this.validToken = validToken;
            this.token = token;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(validToken);
            writer.WriteUTF(token);
            

}

public void Deserialize(IDataReader reader)
{

validToken = reader.ReadBoolean();
            token = reader.ReadUTF();
            

}


}


}