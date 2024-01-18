


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayShowMultipleActorsMessage : NetworkMessage
{

public const uint Id = 7171;
public uint MessageId
{
    get { return Id; }
}

public Types.GameRolePlayActorInformations[] informationsList;
        

public GameRolePlayShowMultipleActorsMessage()
{
}

public GameRolePlayShowMultipleActorsMessage(Types.GameRolePlayActorInformations[] informationsList)
        {
            this.informationsList = informationsList;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)informationsList.Length);
            foreach (var entry in informationsList)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            informationsList = new Types.GameRolePlayActorInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 informationsList[i] = ProtocolTypeManager.GetInstance<Types.GameRolePlayActorInformations>(reader.ReadUShort());
                 informationsList[i].Deserialize(reader);
            }
            

}


}


}