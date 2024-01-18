


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PrismsListRegisterMessage : NetworkMessage
{

public const uint Id = 2829;
public uint MessageId
{
    get { return Id; }
}

public sbyte listen;
        

public PrismsListRegisterMessage()
{
}

public PrismsListRegisterMessage(sbyte listen)
        {
            this.listen = listen;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(listen);
            

}

public void Deserialize(IDataReader reader)
{

listen = reader.ReadSbyte();
            

}


}


}