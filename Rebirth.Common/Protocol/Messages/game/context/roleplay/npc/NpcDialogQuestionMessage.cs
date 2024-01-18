


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class NpcDialogQuestionMessage : NetworkMessage
{

public const uint Id = 5287;
public uint MessageId
{
    get { return Id; }
}

public uint messageId;
        public string[] dialogParams;
        public uint[] visibleReplies;
        

public NpcDialogQuestionMessage()
{
}

public NpcDialogQuestionMessage(uint messageId, string[] dialogParams, uint[] visibleReplies)
        {
            this.messageId = messageId;
            this.dialogParams = dialogParams;
            this.visibleReplies = visibleReplies;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)messageId);
            writer.WriteShort((short)dialogParams.Length);
            foreach (var entry in dialogParams)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteShort((short)visibleReplies.Length);
            foreach (var entry in visibleReplies)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

messageId = reader.ReadVarUhInt();
            var limit = (ushort)reader.ReadUShort();
            dialogParams = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 dialogParams[i] = reader.ReadUTF();
            }
            limit = (ushort)reader.ReadUShort();
            visibleReplies = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 visibleReplies[i] = reader.ReadVarUhInt();
            }
            

}


}


}