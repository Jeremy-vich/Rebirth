


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class DebtsUpdateMessage : NetworkMessage
{

public const uint Id = 1420;
public uint MessageId
{
    get { return Id; }
}

public sbyte action;
        public Types.DebtInformation[] debts;
        

public DebtsUpdateMessage()
{
}

public DebtsUpdateMessage(sbyte action, Types.DebtInformation[] debts)
        {
            this.action = action;
            this.debts = debts;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(action);
            writer.WriteShort((short)debts.Length);
            foreach (var entry in debts)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

action = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            debts = new Types.DebtInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 debts[i] = ProtocolTypeManager.GetInstance<Types.DebtInformation>(reader.ReadUShort());
                 debts[i].Deserialize(reader);
            }
            

}


}


}