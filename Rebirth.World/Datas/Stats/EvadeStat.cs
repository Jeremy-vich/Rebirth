using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Datas.Stats
{
    public class EvadeStat : Stat
    {
        private Func<int> _agility;

        public EvadeStat(Func<int> agility, int source, int @base, int additionnal, Func<int> equiped) : base(source, @base, additionnal, equiped) => (_agility) = (agility);

        public override int Base => base.Base + (int)Math.Floor(_agility() / 10d);
    }
}
