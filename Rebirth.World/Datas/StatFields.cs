using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Datas.Stats;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Datas
{
    public class StatFields
    {
        private Dictionary<PlayerFields, Stat> _stats = new();
        public StatFields(Func<int> level, string raw, Func<PlayerFields, int> equiped)
        {
            if(string.IsNullOrEmpty(raw))
                foreach (PlayerFields item in (PlayerFields[])Enum.GetValues(typeof(PlayerFields)))
                {
                    switch (item)
                    {
                        case PlayerFields.Health:
                            _stats.Add(item, new HealtStat(level, () => Get(PlayerFields.Vitality).Total, 0, 50, 0, () => equiped(item)));
                            break;
                        case PlayerFields.Prospecting:
                            _stats.Add(item, new ProspectingStat(() => Get(PlayerFields.Chance).Total, 0, 100, 0, () => equiped(item)));
                            break;
                        case PlayerFields.AP:
                            _stats.Add(item, new APStat(level, 0, 6, 0, () => equiped(item)));
                            break;
                        case PlayerFields.MP:
                            _stats.Add(item, new Stat(0, 3, 0, () => equiped(item)));
                            break;
                        case PlayerFields.SummonLimit:
                            _stats.Add(item, new Stat(0, 1, 0, () => equiped(item)));
                            break;
                        case PlayerFields.Initiative:
                            _stats.Add(item, new InitStat(() => Get(PlayerFields.Agility).Total, () => Get(PlayerFields.Strength).Total, () => Get(PlayerFields.Intelligence).Total, () => Get(PlayerFields.Chance).Total, 0, 0, 0, () => equiped(item)));
                            break;
                        case PlayerFields.DodgeAPProbability:
                        case PlayerFields.APAttack:
                        case PlayerFields.MPAttack:
                        case PlayerFields.DodgeMPProbability:
                            _stats.Add(item, new PAPMStat(() => Get(PlayerFields.Wisdom).Total, 0, 0, 0, () => equiped(item)));
                            break;
                        case PlayerFields.TackleBlock:
                        case PlayerFields.TackleEvade:
                            _stats.Add(item, new PAPMStat(() => Get(PlayerFields.Agility).Total, 0, 0, 0, () => equiped(item)));
                            break;
                        default:
                            _stats.Add(item, new Stat(() => equiped(item)));
                            break;
                    }
                }
            else
                foreach (var item in raw.Split('|'))
                {
                    var id = item.Split(':')[0];
                    var datas = item.Split(':')[1].Split(',').Select(x => int.Parse(x)).ToArray();
                    var field = (PlayerFields)Enum.Parse(typeof(PlayerFields), id);
                    if (field == PlayerFields.Health)
                        _stats.Add(field, new HealtStat(level, () => Get(PlayerFields.Vitality).Total, datas[0], datas[1], datas[2], () => equiped(field)));
                    else if(field == PlayerFields.Initiative)
                        _stats.Add(field, new InitStat(() => Get(PlayerFields.Agility).Total, () => Get(PlayerFields.Strength).Total, () => Get(PlayerFields.Intelligence).Total, () => Get(PlayerFields.Chance).Total, datas[0], datas[1], datas[2], () => equiped(field)));
                    else if (field == PlayerFields.AP)
                        _stats.Add(field, new APStat(level, datas[0], datas[1], datas[2], () => equiped(field)));
                    else if (field == PlayerFields.DodgeAPProbability || field == PlayerFields.APAttack || field == PlayerFields.MPAttack || field == PlayerFields.DodgeMPProbability)
                        _stats.Add(field, new PAPMStat(() => Get(PlayerFields.Wisdom).Total, datas[0], datas[1], datas[2], () => equiped(field)));
                    else if (field == PlayerFields.Prospecting)
                        _stats.Add(field, new ProspectingStat(() => Get(PlayerFields.Chance).Total, datas[0], datas[1], datas[2], () => equiped(field)));
                    else if (field == PlayerFields.TackleEvade || field == PlayerFields.TackleBlock)
                        _stats.Add(field, new EvadeStat(() => Get(PlayerFields.Agility).Total, datas[0], datas[1], datas[2], () => equiped(field)));
                    else
                        _stats.Add(field, new Stat(datas[0], datas[1], datas[2], () => equiped(field)));
                }
        }

        public Stat Get(PlayerFields field) => _stats[field];

        public int GetBases() => _stats.Values.Sum(x => x.Base);

        public uint GetBase(PlayerFields field, List<List<uint>> chrs)
        {
            uint actual = (uint)_stats[field].Base;
            if (field == PlayerFields.Vitality)
                return actual;
            else if (field == PlayerFields.Wisdom)
                return actual * 3;
            else
            {
                if (actual <= 100)
                    return actual;
                else
                {
                    var @base = (double)actual;
                    var cent = Math.Floor(@base / 100);
                    var add = (@base - (cent * 100)) * (cent + 1);
                    var cent1 = cent * 100 * ((cent + 1) / 2);
                    return (uint)(cent1 + add);
                }
            }
        }

        public override string ToString()
        {
            return string.Join('|', _stats.Select(x => $"{x.Key}:{x.Value}"));
        }
    }

    public class Stat
    {
        private int _source = 0;
        private int _base = 0;
        private int _additionnal = 0;
        private int _context = 0;

        private Func<int> _equiped;

        public Stat(Func<int> equiped) => _equiped = equiped;

        public Stat(int source, int @base, int additionnal, Func<int> equiped)
        {
            _source = source;
            _base = @base;
            _additionnal = additionnal;
            _equiped = equiped;
        }

        public virtual int Total { get { return _source + _base + _additionnal + _context + _equiped(); } }
        public virtual int Base { get { return _source + _base; } }
        public virtual int Additionnal { get { return _additionnal; } }
        public virtual int Context { get { return _context; } }
        public void AddSource(int amount) => _source += amount;
        public void AddBase(int amount) => _base += amount;
        public void AddAdditionnal(int amount) => _additionnal += amount;
        public void AddContext(int amount) => _context += amount;

        public void Reset() => _context = 0;
        public void Restat() => _base = 0;

        public virtual CharacterBaseCharacteristic CharacterBaseCharacteristic { get { return new CharacterBaseCharacteristic(Base, Additionnal, _equiped(), 0, Context); } }

        public override string ToString()
        {
            return $"{_source},{_base},{_additionnal}";
        }
    }
}
