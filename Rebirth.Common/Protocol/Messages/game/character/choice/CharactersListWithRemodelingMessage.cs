


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CharactersListWithRemodelingMessage : CharactersListMessage
{

public const uint Id = 4291;
public uint MessageId
{
    get { return Id; }
}

public Types.CharacterToRemodelInformations[] charactersToRemodel;
        

public CharactersListWithRemodelingMessage()
{
}

public CharactersListWithRemodelingMessage(Types.CharacterBaseInformations[] characters, bool hasStartupActions, Types.CharacterToRemodelInformations[] charactersToRemodel)
         : base(characters, hasStartupActions)
        {
            this.charactersToRemodel = charactersToRemodel;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)charactersToRemodel.Length);
            foreach (var entry in charactersToRemodel)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            charactersToRemodel = new Types.CharacterToRemodelInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 charactersToRemodel[i] = new Types.CharacterToRemodelInformations();
                 charactersToRemodel[i].Deserialize(reader);
            }
            

}


}


}