


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildListApplicationModifiedMessage : NetworkMessage
{

public const uint Id = 4960;
public uint MessageId
{
    get { return Id; }
}

public Types.GuildApplicationInformation apply;
        public sbyte state;
        public double playerId;
        

public GuildListApplicationModifiedMessage()
{
}

public GuildListApplicationModifiedMessage(Types.GuildApplicationInformation apply, sbyte state, double playerId)
        {
            this.apply = apply;
            this.state = state;
            this.playerId = playerId;
        }
        

public void Serialize(IDataWriter writer)
{

apply.Serialize(writer);
            writer.WriteSbyte(state);
            writer.WriteVarLong(playerId);
            

}

public void Deserialize(IDataReader reader)
{

apply = new Types.GuildApplicationInformation();
            apply.Deserialize(reader);
            state = reader.ReadSbyte();
            playerId = reader.ReadVarUhLong();
            

}


}


}