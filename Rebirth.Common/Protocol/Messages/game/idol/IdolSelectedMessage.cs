


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class IdolSelectedMessage : NetworkMessage
{

public const uint Id = 9188;
public uint MessageId
{
    get { return Id; }
}

public bool activate;
        public bool party;
        public uint idolId;
        

public IdolSelectedMessage()
{
}

public IdolSelectedMessage(bool activate, bool party, uint idolId)
        {
            this.activate = activate;
            this.party = party;
            this.idolId = idolId;
        }
        

public void Serialize(IDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, activate);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, party);
            writer.WriteByte(flag1);
            writer.WriteVarShort((int)idolId);
            

}

public void Deserialize(IDataReader reader)
{

byte flag1 = reader.ReadByte();
            activate = BooleanByteWrapper.GetFlag(flag1, 0);
            party = BooleanByteWrapper.GetFlag(flag1, 1);
            idolId = reader.ReadVarUhShort();
            

}


}


}