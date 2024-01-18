


















// Generated on 01/30/2023 13:09:30
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class AbstractFightDispellableEffect
{

public const short Id = 7598;
public virtual short TypeId
{
    get { return Id; }
}

public uint uid;
        public double targetId;
        public short turnDuration;
        public sbyte dispelable;
        public uint spellId;
        public uint effectId;
        public uint parentBoostUid;
        

public AbstractFightDispellableEffect()
{
}

public AbstractFightDispellableEffect(uint uid, double targetId, short turnDuration, sbyte dispelable, uint spellId, uint effectId, uint parentBoostUid)
        {
            this.uid = uid;
            this.targetId = targetId;
            this.turnDuration = turnDuration;
            this.dispelable = dispelable;
            this.spellId = spellId;
            this.effectId = effectId;
            this.parentBoostUid = parentBoostUid;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)uid);
            writer.WriteDouble(targetId);
            writer.WriteShort(turnDuration);
            writer.WriteSbyte(dispelable);
            writer.WriteVarShort((int)spellId);
            writer.WriteVarInt((int)effectId);
            writer.WriteVarInt((int)parentBoostUid);
            

}

public virtual void Deserialize(IDataReader reader)
{

uid = reader.ReadVarUhInt();
            targetId = reader.ReadDouble();
            turnDuration = reader.ReadShort();
            dispelable = reader.ReadSbyte();
            spellId = reader.ReadVarUhShort();
            effectId = reader.ReadVarUhInt();
            parentBoostUid = reader.ReadVarUhInt();
            

}


}


}