


















// Generated on 01/30/2023 13:09:19
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class StatsUpgradeResultMessage : NetworkMessage
{

public const uint Id = 4816;
public uint MessageId
{
    get { return Id; }
}

public sbyte result;
        public uint nbCharacBoost;
        

public StatsUpgradeResultMessage()
{
}

public StatsUpgradeResultMessage(sbyte result, uint nbCharacBoost)
        {
            this.result = result;
            this.nbCharacBoost = nbCharacBoost;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(result);
            writer.WriteVarShort((int)nbCharacBoost);
            

}

public void Deserialize(IDataReader reader)
{

result = reader.ReadSbyte();
            nbCharacBoost = reader.ReadVarUhShort();
            

}


}


}