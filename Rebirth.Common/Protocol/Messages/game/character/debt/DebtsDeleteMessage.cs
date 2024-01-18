


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class DebtsDeleteMessage : NetworkMessage
{

public const uint Id = 8822;
public uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        public double[] debts;
        

public DebtsDeleteMessage()
{
}

public DebtsDeleteMessage(sbyte reason, double[] debts)
        {
            this.reason = reason;
            this.debts = debts;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(reason);
            writer.WriteShort((short)debts.Length);
            foreach (var entry in debts)
            {
                 writer.WriteDouble(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

reason = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            debts = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 debts[i] = reader.ReadDouble();
            }
            

}


}


}