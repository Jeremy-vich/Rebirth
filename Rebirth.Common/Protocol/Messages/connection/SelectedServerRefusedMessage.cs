


















// Generated on 01/30/2023 13:09:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class SelectedServerRefusedMessage : NetworkMessage
{

public const uint Id = 2277;
public uint MessageId
{
    get { return Id; }
}

public uint serverId;
        public sbyte error;
        public sbyte serverStatus;
        

public SelectedServerRefusedMessage()
{
}

public SelectedServerRefusedMessage(uint serverId, sbyte error, sbyte serverStatus)
        {
            this.serverId = serverId;
            this.error = error;
            this.serverStatus = serverStatus;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)serverId);
            writer.WriteSbyte(error);
            writer.WriteSbyte(serverStatus);
            

}

public void Deserialize(IDataReader reader)
{

serverId = reader.ReadVarUhShort();
            error = reader.ReadSbyte();
            serverStatus = reader.ReadSbyte();
            

}


}


}