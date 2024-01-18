using Rebirth.Common.Protocol.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Datas.Stats
{
    public class InitStat : Stat
    {
        private Func<int> _agility;
        private Func<int> _strength;
        private Func<int> _intelligence;
        private Func<int> _chance;
        public InitStat(Func<int> agility, Func<int> strength, Func<int> intelligence, Func<int> chance, int source, int @base, int additionnal, Func<int> equiped) : base(source, @base, additionnal, equiped) => (_agility, _strength, _intelligence, _chance) = (agility, strength, intelligence, chance);

        public override int Base => base.Base + _agility() + _strength() + _intelligence() + _chance();
        public override int Total => base.Total + _agility() + _strength() + _intelligence() + _chance();
        public override CharacterBaseCharacteristic CharacterBaseCharacteristic => new CharacterBaseCharacteristic(Base, Additionnal, 0, 0, Context);
    }
}
