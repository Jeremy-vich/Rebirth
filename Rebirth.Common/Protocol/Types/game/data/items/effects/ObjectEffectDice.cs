


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ObjectEffectDice : ObjectEffect
{

public const short Id = 9849;
public override short TypeId
{
    get { return Id; }
}

public uint diceNum;
        public uint diceSide;
        public uint diceConst;
        

public ObjectEffectDice()
{
}

public ObjectEffectDice(uint actionId, uint diceNum, uint diceSide, uint diceConst)
         : base(actionId)
        {
            this.diceNum = diceNum;
            this.diceSide = diceSide;
            this.diceConst = diceConst;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)diceNum);
            writer.WriteVarInt((int)diceSide);
            writer.WriteVarInt((int)diceConst);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            diceNum = reader.ReadVarUhInt();
            diceSide = reader.ReadVarUhInt();
            diceConst = reader.ReadVarUhInt();
            

}


}


}