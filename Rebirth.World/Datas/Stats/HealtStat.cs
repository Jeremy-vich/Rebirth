using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Datas.Stats
{
    public class HealtStat : Stat
    {
        private Func<int> _level;
        private Func<int> _vitality;
        public HealtStat(Func<int> level, Func<int> vitality, int source, int @base, int additionnal, Func<int> equiped) : base(source, @base, additionnal, equiped)
        {
            _level = level;
            _vitality = vitality;
        }

        public override int Total => base.Total + 5 * _level() + _vitality();
    }
}
