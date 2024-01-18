using PetaPoco;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Models
{
    [TableName("Items")]
    public class Item
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int Gid { get; set; }
        public string EffectsS { get; set; } = "";
        public CharacterInventoryPositionEnum Position { get; set; } = CharacterInventoryPositionEnum.INVENTORY_POSITION_NOT_EQUIPED;
        public int Quantity { get; set; }

        [Ignore]
        public Common.Protocol.Data.Item Template => ObjectDataManager.Get<Common.Protocol.Data.Item>(Gid);
        [Ignore]
        public int Weigth => (int)(Quantity * Template.weight);
        [Ignore]
        public ObjectItem ObjectItem => new((byte)Position, (uint)Gid, ObjectEffects, (uint)Id, (uint)Quantity);
        [Ignore]
        public EffectInstance[] Effects
        {
            get
            {
                var split = EffectsS.Split('|');
                List<EffectInstance> effs = new();
                foreach (var item in split)
                {
                    var infos = item.Split(',');
                    switch ((EffectTypeEnum)int.Parse(infos[0]))
                    {
                        case EffectTypeEnum.EffectInstanceInteger:
                            effs.Add(new EffectInstanceInteger() { effectId = uint.Parse(infos[1]), value = int.Parse(infos[2]) });
                            break;
                        case EffectTypeEnum.EffectInstanceDice:
                            effs.Add(new EffectInstanceDice() { effectId = uint.Parse(infos[1]), diceNum = uint.Parse(infos[2]), diceSide = uint.Parse(infos[3]) });
                            break;
                        case EffectTypeEnum.EffectInstanceMinMax:
                            effs.Add(new EffectInstanceMinMax() { effectId = uint.Parse(infos[1]), min = uint.Parse(infos[2]), max = uint.Parse(infos[3]) });
                            break;
                        case EffectTypeEnum.EffectInstanceString:
                            effs.Add(new EffectInstanceString() { effectId = uint.Parse(infos[1]), text = infos[2] });
                            break;
                        default:
                            break;
                    }
                }
                return effs.ToArray();
            }
        }
        [Ignore]
        public ObjectEffect[] ObjectEffects
        {
            get
            {
                var split = EffectsS.Split('|');
                if (string.IsNullOrEmpty(split[0]))
                    return Array.Empty<ObjectEffect>();
                List<ObjectEffect> effs = new();
                foreach (var item in split)
                {
                    var infos = item.Split(',');
                    switch ((EffectTypeEnum)int.Parse(infos[0]))
                    {
                        case EffectTypeEnum.EffectInstanceInteger:
                            effs.Add(new ObjectEffectInteger(uint.Parse(infos[1]), uint.Parse(infos[2])));
                            break;
                        case EffectTypeEnum.EffectInstanceDice:
                            effs.Add(new ObjectEffectDice(uint.Parse(infos[1]), uint.Parse(infos[2]), uint.Parse(infos[3]), 0));
                            break;
                        case EffectTypeEnum.EffectInstanceMinMax:
                            effs.Add(new ObjectEffectMinMax(uint.Parse(infos[1]),uint.Parse(infos[2]),uint.Parse(infos[3])));
                            break;
                        case EffectTypeEnum.EffectInstanceString:
                            effs.Add(new ObjectEffectString(uint.Parse(infos[1]),infos[2]));
                            break;
                        default:
                            break;
                    }
                }
                return effs.ToArray();
            }
        }
        [Ignore]
        public Dictionary<PlayerFields, Func<int, bool>> Criterias
        {
            get
            {
                Dictionary<PlayerFields, Func<int, bool>> dic = new();
                var splits = Template.criteria.Split('&');
                foreach (var split in splits)
                {
                    var data = split.Substring(0, 2);
                    if (data[0] == 'C')
                    {
                        var ope = split.Substring(2, 1);
                        var value = int.Parse(split.Substring(3, split.Length - 3));
                        PlayerFields stat = PlayerFields.Erosion;
                        if (data[1] == 'S')
                            stat = PlayerFields.Strength;
                        else if (data[1] == 'A')
                            stat = PlayerFields.Agility;
                        else if (data[1] == 'C')
                            stat = PlayerFields.Chance;
                        else if (data[1] == 'I')
                            stat = PlayerFields.Intelligence;
                        else if (data[1] == 'W')
                            stat = PlayerFields.Wisdom;
                        else if (data[1] == 'V')
                            stat = PlayerFields.Vitality;
                        if (ope == ">")
                            dic.Add(stat, (a) => a > value);
                        else if (ope == "<")
                            dic.Add(stat, (a) => a < value);
                        else if (ope == "=")
                            dic.Add(stat, (a) => a == value);
                    }
                }
                return dic;
            }
        }
        [Ignore]
        public Dictionary<PlayerFields, int> Stats
        {
            get
            {
                Dictionary<PlayerFields, int> dic = new();

                foreach (var item in Effects.ToList().FindAll(x => x is EffectInstanceInteger))
                {
                    string text = ((EffectsEnum)item.effectId).ToString();
                    PlayerFields stat = (PlayerFields)Enum.Parse(typeof(PlayerFields), text.Replace("Effect_Add", "").Replace("Effect_Sub", ""));
                    dic.Add(stat, (item as EffectInstanceInteger).value);
                }
                
                return dic;
            }
        }
        public int Stat(PlayerFields field) => Stats.ContainsKey(field) ? Stats[field] : 0;

        public Item() { }
        public Item(Item item, int charId, CharacterInventoryPositionEnum pos) {
            Gid = item.Gid;
            EffectsS = item.EffectsS;
            CharacterId = charId;
            Position = pos;
            Quantity = 1;
        }
        public Item(Item item, int charId, CharacterInventoryPositionEnum pos, int quantity)
        {
            Gid = item.Gid;
            EffectsS = item.EffectsS;
            CharacterId = charId;
            Position = pos;
            Quantity = quantity;
        }
        public Item(int gid, int amount, int charId, bool isMax = false)
        {
            Gid = gid;
            Quantity = amount;
            CharacterId = charId;

            Random rdn = new Random();
            var rng = rdn.Next(0, Enum.GetNames(typeof(ObjectRarityEnum)).Length);
            ObjectRarityEnum rarityEnum = (ObjectRarityEnum)rng;
            int multipl = rarityEnum == ObjectRarityEnum.Unique ? 10 : 
                rarityEnum == ObjectRarityEnum.Legendaire ? 6 : 
                rarityEnum == ObjectRarityEnum.Mythique ? 4 : 
                rarityEnum == ObjectRarityEnum.Rare ? 2 : 1;
            var color = rarityEnum == ObjectRarityEnum.Unique ? "#f1c40f" :
                rarityEnum == ObjectRarityEnum.Legendaire ? "#e67e22" :
                rarityEnum == ObjectRarityEnum.Mythique ? "#8e44ad" :
                rarityEnum == ObjectRarityEnum.Rare ? "#2980b9" : "#27ae60";
            var text = $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml(color).ToArgb():X}\">{rarityEnum}</font>";        
            List<EffectInstance> effs = new() ;
            if ((ItemTypeEnum)Template.typeId == ItemTypeEnum.AMULET ||
                (ItemTypeEnum)Template.typeId == ItemTypeEnum.BOW ||
                (ItemTypeEnum)Template.typeId == ItemTypeEnum.WAND ||
                (ItemTypeEnum)Template.typeId == ItemTypeEnum.STAFF ||
                (ItemTypeEnum)Template.typeId == ItemTypeEnum.DAGGER ||
                (ItemTypeEnum)Template.typeId == ItemTypeEnum.SWORD ||
                (ItemTypeEnum)Template.typeId == ItemTypeEnum.HAMMER ||
                (ItemTypeEnum)Template.typeId == ItemTypeEnum.SHOVEL ||
                (ItemTypeEnum)Template.typeId == ItemTypeEnum.RING ||
                (ItemTypeEnum)Template.typeId == ItemTypeEnum.BELT ||
                (ItemTypeEnum)Template.typeId == ItemTypeEnum.BOOTS ||
                (ItemTypeEnum)Template.typeId == ItemTypeEnum.HAT ||
                (ItemTypeEnum)Template.typeId == ItemTypeEnum.CLOAK ||
                (ItemTypeEnum)Template.typeId == ItemTypeEnum.AXE ||
                (ItemTypeEnum)Template.typeId == ItemTypeEnum.PICKAXE)
                effs.Add(new EffectInstanceString() { effectId = 990, text = text });
            else
                multipl = 1;
            foreach (var eff in Template.possibleEffects)
            {
                if(eff is EffectInstanceMinMax)
                {
                    effs.Add(eff);
                    continue;
                }
                var type = (EffectsEnum)eff.effectId;
                int actualMulti = multipl;
                if(type == EffectsEnum.Effect_AddAP_111 || type == EffectsEnum.Effect_AddMP || type == EffectsEnum.Effect_AddMP_128)
                {
                    actualMulti = 1;
                }
                if(eff is EffectInstanceDice)
                {
                    var effe = eff as EffectInstanceDice;
                    if(effe.diceSide <= effe.diceNum)
                        effs.Add(new EffectInstanceInteger() { effectId = eff.effectId, value = (int)(effe.diceNum * actualMulti) });
                    else
                        effs.Add(new EffectInstanceInteger() { effectId = eff.effectId, value = new Random().Next((int)effe.diceNum, (int)effe.diceSide * actualMulti)});
                }
                else if(eff is EffectInstanceInteger)
                {
                    var effe = eff as EffectInstanceInteger;
                    effs.Add(new EffectInstanceInteger() { effectId = eff.effectId, value = effe.value * actualMulti });
                }
                    
            }
            EffectsS = RawEffects(effs.ToArray());
        }

        public static string RawEffects(EffectInstance[] effs)
        {
            var result = "";
            foreach (var eff in effs)
            {
                if(eff is EffectInstanceInteger)
                {
                    var effe = eff as EffectInstanceInteger;
                    result += $"{(uint)EffectTypeEnum.EffectInstanceInteger},{effe.effectId},{effe.value}|";
                } 
                else if(eff is EffectInstanceDice)
                {
                    var effe = eff as EffectInstanceDice;
                    result += $"{(uint)EffectTypeEnum.EffectInstanceDice},{effe.effectId},{effe.diceNum},{effe.diceSide}|";
                }
                else if (eff is EffectInstanceMinMax)
                {
                    var effe = eff as EffectInstanceMinMax;
                    result += $"{(uint)EffectTypeEnum.EffectInstanceMinMax},{effe.effectId},{effe.min},{effe.max}|";
                } 
                else if (eff is EffectInstanceString)
                {
                    var effe = eff as EffectInstanceString;
                    result += $"{(uint)EffectTypeEnum.EffectInstanceString},{effe.effectId},{effe.text}|";
                }
            }
            return result.Substring(0, (result.Length > 0 ? result.Length - 1 : 0));
        }
    }
}
