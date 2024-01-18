using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Datas.Stats
{
    public class APStat : Stat
    {
        private Func<int> _level;
        public APStat(Func<int> level, int source, int @base, int additionnal, Func<int> equiped) : base(source, @base, additionnal, equiped)
        {
            _level = level;
        }

        public override int Base => base.Base + _level() >= 100 ? 1 : 0;
    }
}
