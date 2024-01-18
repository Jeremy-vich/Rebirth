


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameContextCreateMessage : NetworkMessage
{

public const uint Id = 7963;
public uint MessageId
{
    get { return Id; }
}

public sbyte context;
        

public GameContextCreateMessage()
{
}

public GameContextCreateMessage(sbyte context)
        {
            this.context = context;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(context);
            

}

public void Deserialize(IDataReader reader)
{

context = reader.ReadSbyte();
            

}


}


}