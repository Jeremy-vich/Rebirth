


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HaapiShopApiKeyMessage : NetworkMessage
{

public const uint Id = 4042;
public uint MessageId
{
    get { return Id; }
}

public string token;
        

public HaapiShopApiKeyMessage()
{
}

public HaapiShopApiKeyMessage(string token)
        {
            this.token = token;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(token);
            

}

public void Deserialize(IDataReader reader)
{

token = reader.ReadUTF();
            

}


}


}