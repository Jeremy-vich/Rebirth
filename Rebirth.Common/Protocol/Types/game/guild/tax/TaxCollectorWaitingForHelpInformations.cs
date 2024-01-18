


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class TaxCollectorWaitingForHelpInformations : TaxCollectorComplementaryInformations
{

public const short Id = 5562;
public override short TypeId
{
    get { return Id; }
}

public Types.ProtectedEntityWaitingForHelpInfo waitingForHelpInfo;
        

public TaxCollectorWaitingForHelpInformations()
{
}

public TaxCollectorWaitingForHelpInformations(Types.ProtectedEntityWaitingForHelpInfo waitingForHelpInfo)
        {
            this.waitingForHelpInfo = waitingForHelpInfo;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            waitingForHelpInfo.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            waitingForHelpInfo = new Types.ProtectedEntityWaitingForHelpInfo();
            waitingForHelpInfo.Deserialize(reader);
            

}


}


}