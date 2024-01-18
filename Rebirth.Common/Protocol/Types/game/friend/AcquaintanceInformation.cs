


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class AcquaintanceInformation : AbstractContactInformations
{

public const short Id = 6961;
public override short TypeId
{
    get { return Id; }
}

public sbyte playerState;
        

public AcquaintanceInformation()
{
}

public AcquaintanceInformation(int accountId, Types.AccountTagInformation accountTag, sbyte playerState)
         : base(accountId, accountTag)
        {
            this.playerState = playerState;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(playerState);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            playerState = reader.ReadSbyte();
            

}


}


}