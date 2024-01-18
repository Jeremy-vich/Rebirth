


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CharacterReplayWithRemodelRequestMessage : CharacterReplayRequestMessage
{

public const uint Id = 5408;
public uint MessageId
{
    get { return Id; }
}

public Types.RemodelingInformation remodel;
        

public CharacterReplayWithRemodelRequestMessage()
{
}

public CharacterReplayWithRemodelRequestMessage(double characterId, Types.RemodelingInformation remodel)
         : base(characterId)
        {
            this.remodel = remodel;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            remodel.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            remodel = new Types.RemodelingInformation();
            remodel.Deserialize(reader);
            

}


}


}