


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ObjectItemToSellInBid : ObjectItemToSell
{

public const short Id = 1881;
public override short TypeId
{
    get { return Id; }
}

public int unsoldDelay;
        

public ObjectItemToSellInBid()
{
}

public ObjectItemToSellInBid(uint objectGID, Types.ObjectEffect[] effects, uint objectUID, uint quantity, double objectPrice, int unsoldDelay)
         : base(objectGID, effects, objectUID, quantity, objectPrice)
        {
            this.unsoldDelay = unsoldDelay;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(unsoldDelay);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            unsoldDelay = reader.ReadInt();
            

}


}


}