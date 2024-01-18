


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MoodSmileyResultMessage : NetworkMessage
{

public const uint Id = 8828;
public uint MessageId
{
    get { return Id; }
}

public sbyte resultCode;
        public uint smileyId;
        

public MoodSmileyResultMessage()
{
}

public MoodSmileyResultMessage(sbyte resultCode, uint smileyId)
        {
            this.resultCode = resultCode;
            this.smileyId = smileyId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(resultCode);
            writer.WriteVarShort((int)smileyId);
            

}

public void Deserialize(IDataReader reader)
{

resultCode = reader.ReadSbyte();
            smileyId = reader.ReadVarUhShort();
            

}


}


}