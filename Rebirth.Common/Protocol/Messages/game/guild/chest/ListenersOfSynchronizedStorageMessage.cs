


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ListenersOfSynchronizedStorageMessage : NetworkMessage
{

public const uint Id = 8286;
public uint MessageId
{
    get { return Id; }
}

public string[] players;
        

public ListenersOfSynchronizedStorageMessage()
{
}

public ListenersOfSynchronizedStorageMessage(string[] players)
        {
            this.players = players;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)players.Length);
            foreach (var entry in players)
            {
                 writer.WriteUTF(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            players = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 players[i] = reader.ReadUTF();
            }
            

}


}


}