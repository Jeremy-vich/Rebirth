


















// Generated on 01/30/2023 13:09:19
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class StatsUpgradeRequestMessage : NetworkMessage
{

public const uint Id = 7878;
public uint MessageId
{
    get { return Id; }
}

public bool useAdditionnal;
        public sbyte statId;
        public uint boostPoint;
        

public StatsUpgradeRequestMessage()
{
}

public StatsUpgradeRequestMessage(bool useAdditionnal, sbyte statId, uint boostPoint)
        {
            this.useAdditionnal = useAdditionnal;
            this.statId = statId;
            this.boostPoint = boostPoint;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(useAdditionnal);
            writer.WriteSbyte(statId);
            writer.WriteVarShort((int)boostPoint);
            

}

public void Deserialize(IDataReader reader)
{

useAdditionnal = reader.ReadBoolean();
            statId = reader.ReadSbyte();
            boostPoint = reader.ReadVarUhShort();
            

}


}


}