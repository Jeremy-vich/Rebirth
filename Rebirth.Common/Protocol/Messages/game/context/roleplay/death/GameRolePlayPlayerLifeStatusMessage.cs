


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayPlayerLifeStatusMessage : NetworkMessage
{

public const uint Id = 7815;
public uint MessageId
{
    get { return Id; }
}

public sbyte state;
        public double phenixMapId;
        

public GameRolePlayPlayerLifeStatusMessage()
{
}

public GameRolePlayPlayerLifeStatusMessage(sbyte state, double phenixMapId)
        {
            this.state = state;
            this.phenixMapId = phenixMapId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(state);
            writer.WriteDouble(phenixMapId);
            

}

public void Deserialize(IDataReader reader)
{

state = reader.ReadSbyte();
            phenixMapId = reader.ReadDouble();
            

}


}


}