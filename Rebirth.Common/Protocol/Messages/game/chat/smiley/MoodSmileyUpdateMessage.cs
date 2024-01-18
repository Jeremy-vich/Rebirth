


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MoodSmileyUpdateMessage : NetworkMessage
{

public const uint Id = 2215;
public uint MessageId
{
    get { return Id; }
}

public int accountId;
        public double playerId;
        public uint smileyId;
        

public MoodSmileyUpdateMessage()
{
}

public MoodSmileyUpdateMessage(int accountId, double playerId, uint smileyId)
        {
            this.accountId = accountId;
            this.playerId = playerId;
            this.smileyId = smileyId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(accountId);
            writer.WriteVarLong(playerId);
            writer.WriteVarShort((int)smileyId);
            

}

public void Deserialize(IDataReader reader)
{

accountId = reader.ReadInt();
            playerId = reader.ReadVarUhLong();
            smileyId = reader.ReadVarUhShort();
            

}


}


}