


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CheckFileRequestMessage : NetworkMessage
{

public const uint Id = 8761;
public uint MessageId
{
    get { return Id; }
}

public string filename;
        public sbyte type;
        

public CheckFileRequestMessage()
{
}

public CheckFileRequestMessage(string filename, sbyte type)
        {
            this.filename = filename;
            this.type = type;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(filename);
            writer.WriteSbyte(type);
            

}

public void Deserialize(IDataReader reader)
{

filename = reader.ReadUTF();
            type = reader.ReadSbyte();
            

}


}


}