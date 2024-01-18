


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BreachCharactersMessage : NetworkMessage
{

public const uint Id = 611;
public uint MessageId
{
    get { return Id; }
}

public double[] characters;
        

public BreachCharactersMessage()
{
}

public BreachCharactersMessage(double[] characters)
        {
            this.characters = characters;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)characters.Length);
            foreach (var entry in characters)
            {
                 writer.WriteVarLong(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            characters = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 characters[i] = reader.ReadVarUhLong();
            }
            

}


}


}