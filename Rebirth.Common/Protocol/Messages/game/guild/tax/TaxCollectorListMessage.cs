


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TaxCollectorListMessage : AbstractTaxCollectorListMessage
{

public const uint Id = 5925;
public uint MessageId
{
    get { return Id; }
}

public sbyte nbcollectorMax;
        public Types.TaxCollectorFightersInformation[] fightersInformations;
        public sbyte infoType;
        

public TaxCollectorListMessage()
{
}

public TaxCollectorListMessage(Types.TaxCollectorInformations[] informations, sbyte nbcollectorMax, Types.TaxCollectorFightersInformation[] fightersInformations, sbyte infoType)
         : base(informations)
        {
            this.nbcollectorMax = nbcollectorMax;
            this.fightersInformations = fightersInformations;
            this.infoType = infoType;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(nbcollectorMax);
            writer.WriteShort((short)fightersInformations.Length);
            foreach (var entry in fightersInformations)
            {
                 entry.Serialize(writer);
            }
            writer.WriteSbyte(infoType);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            nbcollectorMax = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            fightersInformations = new Types.TaxCollectorFightersInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 fightersInformations[i] = new Types.TaxCollectorFightersInformation();
                 fightersInformations[i].Deserialize(reader);
            }
            infoType = reader.ReadSbyte();
            

}


}


}