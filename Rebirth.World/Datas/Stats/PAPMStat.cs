using Rebirth.Common.Protocol.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Datas.Stats
{
    public class PAPMStat : Stat
    {
        private Func<int> _wisdom;

        public PAPMStat(Func<int> wisdom, int source, int @base, int additionnal, Func<int> equiped) : base(source, @base, additionnal, equiped) => (_wisdom) = (wisdom);

        public override int Base => base.Base + (int)Math.Floor(_wisdom() / 10d);
    }
}
