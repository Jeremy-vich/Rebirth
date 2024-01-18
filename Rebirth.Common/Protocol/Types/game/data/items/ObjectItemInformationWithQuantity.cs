


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ObjectItemInformationWithQuantity : ObjectItemMinimalInformation
{

public const short Id = 3982;
public override short TypeId
{
    get { return Id; }
}

public uint quantity;
        

public ObjectItemInformationWithQuantity()
{
}

public ObjectItemInformationWithQuantity(uint objectGID, Types.ObjectEffect[] effects, uint quantity)
         : base(objectGID, effects)
        {
            this.quantity = quantity;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)quantity);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            quantity = reader.ReadVarUhInt();
            

}


}


}