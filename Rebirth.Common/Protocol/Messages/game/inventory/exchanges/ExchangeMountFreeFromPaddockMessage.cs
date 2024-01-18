


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeMountFreeFromPaddockMessage : NetworkMessage
{

public const uint Id = 8647;
public uint MessageId
{
    get { return Id; }
}

public string name;
        public short worldX;
        public short worldY;
        public string liberator;
        

public ExchangeMountFreeFromPaddockMessage()
{
}

public ExchangeMountFreeFromPaddockMessage(string name, short worldX, short worldY, string liberator)
        {
            this.name = name;
            this.worldX = worldX;
            this.worldY = worldY;
            this.liberator = liberator;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(name);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteUTF(liberator);
            

}

public void Deserialize(IDataReader reader)
{

name = reader.ReadUTF();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            liberator = reader.ReadUTF();
            

}


}


}