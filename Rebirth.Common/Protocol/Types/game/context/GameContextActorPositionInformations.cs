


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameContextActorPositionInformations
{

public const short Id = 4353;
public virtual short TypeId
{
    get { return Id; }
}

public double contextualId;
        public Types.EntityDispositionInformations disposition;
        

public GameContextActorPositionInformations()
{
}

public GameContextActorPositionInformations(double contextualId, Types.EntityDispositionInformations disposition)
        {
            this.contextualId = contextualId;
            this.disposition = disposition;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteDouble(contextualId);
            writer.WriteShort(disposition.TypeId);
            disposition.Serialize(writer);
            

}

public virtual void Deserialize(IDataReader reader)
{

contextualId = reader.ReadDouble();
            disposition = ProtocolTypeManager.GetInstance<Types.EntityDispositionInformations>(reader.ReadUShort());
            disposition.Deserialize(reader);
            

}


}


}