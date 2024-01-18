


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CheckFileMessage : NetworkMessage
{

public const uint Id = 1064;
public uint MessageId
{
    get { return Id; }
}

public string filenameHash;
        public sbyte type;
        public string value;
        

public CheckFileMessage()
{
}

public CheckFileMessage(string filenameHash, sbyte type, string value)
        {
            this.filenameHash = filenameHash;
            this.type = type;
            this.value = value;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(filenameHash);
            writer.WriteSbyte(type);
            writer.WriteUTF(value);
            

}

public void Deserialize(IDataReader reader)
{

filenameHash = reader.ReadUTF();
            type = reader.ReadSbyte();
            value = reader.ReadUTF();
            

}


}


}