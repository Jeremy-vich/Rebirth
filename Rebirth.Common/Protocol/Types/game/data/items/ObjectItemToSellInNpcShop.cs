


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ObjectItemToSellInNpcShop : ObjectItemMinimalInformation
{

public const short Id = 3715;
public override short TypeId
{
    get { return Id; }
}

public double objectPrice;
        public string buyCriterion;
        

public ObjectItemToSellInNpcShop()
{
}

public ObjectItemToSellInNpcShop(uint objectGID, Types.ObjectEffect[] effects, double objectPrice, string buyCriterion)
         : base(objectGID, effects)
        {
            this.objectPrice = objectPrice;
            this.buyCriterion = buyCriterion;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(objectPrice);
            writer.WriteUTF(buyCriterion);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            objectPrice = reader.ReadVarUhLong();
            buyCriterion = reader.ReadUTF();
            

}


}


}