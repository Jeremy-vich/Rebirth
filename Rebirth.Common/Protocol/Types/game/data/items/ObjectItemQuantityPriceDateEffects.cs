


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ObjectItemQuantityPriceDateEffects : ObjectItemGenericQuantity
{

public const short Id = 2847;
public override short TypeId
{
    get { return Id; }
}

public double price;
        public Types.ObjectEffects effects;
        public int date;
        

public ObjectItemQuantityPriceDateEffects()
{
}

public ObjectItemQuantityPriceDateEffects(uint objectGID, uint quantity, double price, Types.ObjectEffects effects, int date)
         : base(objectGID, quantity)
        {
            this.price = price;
            this.effects = effects;
            this.date = date;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(price);
            effects.Serialize(writer);
            writer.WriteInt(date);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            price = reader.ReadVarUhLong();
            effects = new Types.ObjectEffects();
            effects.Deserialize(reader);
            date = reader.ReadInt();
            

}


}


}