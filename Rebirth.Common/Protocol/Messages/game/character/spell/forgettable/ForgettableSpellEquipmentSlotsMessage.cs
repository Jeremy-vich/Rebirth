


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ForgettableSpellEquipmentSlotsMessage : NetworkMessage
{

public const uint Id = 4599;
public uint MessageId
{
    get { return Id; }
}

public int quantity;
        

public ForgettableSpellEquipmentSlotsMessage()
{
}

public ForgettableSpellEquipmentSlotsMessage(int quantity)
        {
            this.quantity = quantity;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)quantity);
            

}

public void Deserialize(IDataReader reader)
{

quantity = reader.ReadVarShort();
            

}


}


}