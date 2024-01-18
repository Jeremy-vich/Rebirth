


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BreachBranchesMessage : NetworkMessage
{

public const uint Id = 7075;
public uint MessageId
{
    get { return Id; }
}

public Types.ExtendedBreachBranch[] branches;
        

public BreachBranchesMessage()
{
}

public BreachBranchesMessage(Types.ExtendedBreachBranch[] branches)
        {
            this.branches = branches;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)branches.Length);
            foreach (var entry in branches)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            branches = new Types.ExtendedBreachBranch[limit];
            for (int i = 0; i < limit; i++)
            {
                 branches[i] = ProtocolTypeManager.GetInstance<Types.ExtendedBreachBranch>(reader.ReadUShort());
                 branches[i].Deserialize(reader);
            }
            

}


}


}