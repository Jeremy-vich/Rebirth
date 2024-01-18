


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class CharacterCharacteristicDetailed : CharacterCharacteristic
{

public const short Id = 3932;
public override short TypeId
{
    get { return Id; }
}

public int @base;
        public int additional;
        public int objectsAndMountBonus;
        public int alignGiftBonus;
        public int contextModif;
        

public CharacterCharacteristicDetailed()
{
}

public CharacterCharacteristicDetailed(short characteristicId, int @base, int additional, int objectsAndMountBonus, int alignGiftBonus, int contextModif)
         : base(characteristicId)
        {
            this.@base = @base;
            this.additional = additional;
            this.objectsAndMountBonus = objectsAndMountBonus;
            this.alignGiftBonus = alignGiftBonus;
            this.contextModif = contextModif;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)@base);
            writer.WriteVarInt((int)additional);
            writer.WriteVarInt((int)objectsAndMountBonus);
            writer.WriteVarInt((int)alignGiftBonus);
            writer.WriteVarInt((int)contextModif);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            @base = reader.ReadVarInt();
            additional = reader.ReadVarInt();
            objectsAndMountBonus = reader.ReadVarInt();
            alignGiftBonus = reader.ReadVarInt();
            contextModif = reader.ReadVarInt();
            

}


}


}