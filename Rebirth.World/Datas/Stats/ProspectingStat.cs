using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Datas.Stats
{
    public class ProspectingStat : Stat
    {
        private Func<int> _chance;

        public ProspectingStat(Func<int> chance, int source, int @base, int additionnal, Func<int> equiped) : base(source, @base, additionnal, equiped) => (_chance) = (chance);

        public override int Base => base.Base + (int)Math.Floor(_chance() / 10d);
    }
}
