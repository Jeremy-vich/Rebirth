


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BasicCharactersListMessage : NetworkMessage
{

public const uint Id = 4706;
public uint MessageId
{
    get { return Id; }
}

public Types.CharacterBaseInformations[] characters;
        

public BasicCharactersListMessage()
{
}

public BasicCharactersListMessage(Types.CharacterBaseInformations[] characters)
        {
            this.characters = characters;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)characters.Length);
            foreach (var entry in characters)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            characters = new Types.CharacterBaseInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 characters[i] = ProtocolTypeManager.GetInstance<Types.CharacterBaseInformations>(reader.ReadUShort());
                 characters[i].Deserialize(reader);
            }
            

}


}


}