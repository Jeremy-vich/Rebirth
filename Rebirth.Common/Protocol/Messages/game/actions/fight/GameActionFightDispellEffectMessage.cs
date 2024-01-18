


















// Generated on 01/30/2023 13:09:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionFightDispellEffectMessage : GameActionFightDispellMessage
{

public const uint Id = 3580;
public uint MessageId
{
    get { return Id; }
}

public int boostUID;
        

public GameActionFightDispellEffectMessage()
{
}

public GameActionFightDispellEffectMessage(uint actionId, double sourceId, double targetId, bool verboseCast, int boostUID)
         : base(actionId, sourceId, targetId, verboseCast)
        {
            this.boostUID = boostUID;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(boostUID);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            boostUID = reader.ReadInt();
            

}


}


}