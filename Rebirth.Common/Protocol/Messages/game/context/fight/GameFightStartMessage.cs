


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightStartMessage : NetworkMessage
{

public const uint Id = 3034;
public uint MessageId
{
    get { return Id; }
}

public Types.Idol[] idols;
        

public GameFightStartMessage()
{
}

public GameFightStartMessage(Types.Idol[] idols)
        {
            this.idols = idols;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)idols.Length);
            foreach (var entry in idols)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            idols = new Types.Idol[limit];
            for (int i = 0; i < limit; i++)
            {
                 idols[i] = new Types.Idol();
                 idols[i].Deserialize(reader);
            }
            

}


}


}