


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PrismFightAttackerRemoveMessage : NetworkMessage
{

public const uint Id = 9107;
public uint MessageId
{
    get { return Id; }
}

public uint subAreaId;
        public uint fightId;
        public double fighterToRemoveId;
        

public PrismFightAttackerRemoveMessage()
{
}

public PrismFightAttackerRemoveMessage(uint subAreaId, uint fightId, double fighterToRemoveId)
        {
            this.subAreaId = subAreaId;
            this.fightId = fightId;
            this.fighterToRemoveId = fighterToRemoveId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)subAreaId);
            writer.WriteVarShort((int)fightId);
            writer.WriteVarLong(fighterToRemoveId);
            

}

public void Deserialize(IDataReader reader)
{

subAreaId = reader.ReadVarUhShort();
            fightId = reader.ReadVarUhShort();
            fighterToRemoveId = reader.ReadVarUhLong();
            

}


}


}