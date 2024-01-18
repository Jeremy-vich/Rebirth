


















// Generated on 01/30/2023 13:09:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HelloConnectMessage : NetworkMessage
{

public const uint Id = 7439;
public uint MessageId
{
    get { return Id; }
}

public string salt;
        public sbyte[] key;
        

public HelloConnectMessage()
{
}

public HelloConnectMessage(string salt, sbyte[] key)
        {
            this.salt = salt;
            this.key = key;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(salt);
            writer.WriteVarInt((int)(ushort)key.Length);
            foreach (var entry in key)
            {
                 writer.WriteSbyte(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

salt = reader.ReadUTF();
            var limit = (ushort)reader.ReadVarInt();
            key = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 key[i] = reader.ReadSbyte();
            }
            

}


}


}