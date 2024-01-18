using PetaPoco;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.GameData.Maps;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Datas;
using Rebirth.World.Datas.Dialogs;
using Rebirth.World.Managers;
using Rebirth.World.Pathfinder;
using Rebirth.World.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Markup;
using static System.Net.Mime.MediaTypeNames;
using MapsManager = Rebirth.World.Managers.MapsManager;
using Timer = System.Timers.Timer;

namespace Rebirth.World.Models
{
    [PrimaryKey("Id")]
    [TableName("Character")]
    public class Character
    {
        public object Context = new();
        #region DataBase vars
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Name { get; set; } = "";
        public byte BreedId { get; set; }
        public string EntityLook { get; set; } = "";
        public bool Sex { get; set; }
        public double Exp { get; set; }
        public int MapId { get; set; }
        public int CellId { get; set; }
        public int ZaapSave { get; set; }
        public DirectionsEnum Direction { get; set; }
        public string Statistiques { get; set; } = "";
        public int Kamas { get; set; }
        public CharacterRoleEnum Role { get; set; }

        [Ignore]
        public IDialog? Dialog { get; set; }
        #endregion

        #region Get
        [Ignore]
        public List<Spell> Spells => SpellsManager.Instance.Get(Id);

        [Ignore]
        public Map? Map { get { return MapsManager.Instance.Get(MapId); } }

        [Ignore]
        public EntityLook EntityLooke
        {
            get => new Models.EntityLook(EntityLook);
        }

        [Ignore]
        public CharacterBaseInformations CharacterBaseInformations
        {
            get
            {
                return new CharacterBaseInformations(Id, Name, Level, EntityLooke.GetEntityLook(), BreedId, Sex);
            }
        }

        [Ignore]
        public GameRolePlayCharacterInformations GameRolePlayCharacterInformations
        {
            get
            {
                List<HumanOption> ops = new();
                if (Ornement != null)
                    ops.Add(new HumanOptionOrnament((uint)Ornement.OrnementId));
                if (Title != null)
                    ops.Add(new HumanOptionTitle((uint)Title.TitleId, ""));
                return new GameRolePlayCharacterInformations(Id,
                    EntityLooke.GetEntityLook(),
                    new EntityDispositionInformations((short)CellId, (sbyte)Direction),
                    Name,
                    new HumanInformations(new ActorRestrictionsInformations(),
                        Sex,
                        ops.ToArray()),
                    AccountId,
                    new ActorAlignmentInformations(0, 0, 0, 0 + Level));
            }
        }

        [Ignore]
        public List<Title> Titles => Starter.DatabaseWorld.Fetch<Title>("WHERE CharacterId=@0", Id);

        [Ignore]
        public Title? Title => Titles.FirstOrDefault(x => x.Enable);

        [Ignore]
        public List<Ornement> Ornements => Starter.DatabaseWorld.Fetch<Ornement>("WHERE CharacterId=@0", Id);

        [Ignore]
        public Ornement? Ornement => Ornements.FirstOrDefault(x => x.Enable);

        [Ignore]
        public List<Emote> Emotes => Starter.DatabaseWorld.Fetch<Emote>("WHERE CharacterId=@0", Id);

        [Ignore]
        public GameRolePlayActorInformations GameRolePlayActorInformations
        {
            get
            {
                return new GameRolePlayActorInformations(Id, EntityLooke.GetEntityLook(), new EntityDispositionInformations(510, (sbyte)DirectionsEnum.DIRECTION_SOUTH_WEST));
            }
        }

        [Ignore]
        public ActorOrientation ActorOrientation
        {
            get
            {
                return new ActorOrientation(Id, (sbyte)Direction);
            }
        }

        [Ignore]
        public PartyMemberInformations PartyMemberInformations => new PartyMemberInformations(Id, Name, Level, EntityLooke.GetEntityLook(), BreedId, Sex, (uint)Stats.Get(PlayerFields.Health).Total, (uint)Stats.Get(PlayerFields.Health).Total, (uint)Stats.Get(PlayerFields.Prospecting).Total, 0, (uint)Stats.Get(PlayerFields.Initiative).Total, 0, (short)Map.Position.posX, (short)Map.Position.posY, Map.Template.Id, (uint)Map.Template.SubAreaId, new PlayerStatus((sbyte)PlayerStatusEnum.PLAYER_STATUS_AVAILABLE), Array.Empty<PartyCompanionMemberInformations>());

        public Dictionary<uint, double> Hosteds = new();
        public PartyGuestInformations PartyGuestInformations(uint partyId) => new PartyGuestInformations(Id, Hosteds[partyId], Name, EntityLooke.GetEntityLook(), (sbyte)BreedId, Sex, new PlayerStatus((sbyte)PlayerStatusEnum.PLAYER_STATUS_AVAILABLE), Array.Empty<PartyCompanionMemberInformations>());
        
        [Ignore]
        public byte Level => (byte)ExperienceManager.Instance.Get(Enums.ExperienceEnum.Character, Exp);

        [Ignore]
        public int StatsPoints
        {
            get
            {
                if (Stats == null)
                    Init();
                var points = (Level - 1) * 5 
                    - Stats.GetBase(PlayerFields.Agility, Breed.statsPointsForAgility)
                    - Stats.GetBase(PlayerFields.Strength, Breed.statsPointsForStrength)
                    - Stats.GetBase(PlayerFields.Intelligence, Breed.statsPointsForIntelligence)
                    - Stats.GetBase(PlayerFields.Wisdom, Breed.statsPointsForWisdom)
                    - Stats.GetBase(PlayerFields.Chance, Breed.statsPointsForChance)
                    - Stats.GetBase(PlayerFields.Vitality, Breed.statsPointsForVitality);
                return (int)points;
            }
        }

        [Ignore]
        public int SpellPoints
        {
            get
            {
                var total = Level - 1;
                var investie = Spells.Sum(x => x.Level > 1 ? Enumerable.Range(1, x.Level - 1).Sum() : 0);
                return total - investie < 0 ? 0 : total - investie;
            }
        }

        [Ignore]
        public Breed Breed { get { return ObjectDataManager.Get<Breed>(BreedId); } }

        [Ignore]
        public Dictionary<PlayerFields, int>[] ItemsEquipped => Items.FindAll(x => x.Position != CharacterInventoryPositionEnum.INVENTORY_POSITION_NOT_EQUIPED).Select(x => x.Stats).ToArray();

        public int ItemsStat(PlayerFields field)
        {
            var items = Items.FindAll(x => x.Position != CharacterInventoryPositionEnum.INVENTORY_POSITION_NOT_EQUIPED);
            var @base = items.Sum(x => x.Stat(field));

            List<ItemSet> sets = new();
            foreach (var item in items)
                if (item.Template.itemSetId > 0 && !sets.Any(x => x.id == item.Template.itemSetId))
                    sets.Add(ObjectDataManager.Get<ItemSet>(item.Template.itemSetId));

            var equipped = 0;
            foreach (var set in sets)
            {
                var goodSet = set.effects[items.FindAll(x => x.Template.itemSetId == set.id).Count - 1];
                foreach (var item in goodSet.FindAll(x => x is EffectInstanceInteger))
                {
                    string text = ((EffectsEnum)item.effectId).ToString();
                    PlayerFields stat = (PlayerFields)Enum.Parse(typeof(PlayerFields), text.Replace("Effect_Add", "").Replace("Effect_Sub", ""));
                    if (stat == field)
                    {
                        if (item is EffectInstanceDice)
                            equipped += (int)(item as EffectInstanceDice).diceNum;                       
                        else
                            equipped += (item as EffectInstanceInteger).value;
                    }
                }
            }

            return @base + equipped;
        }


        [Ignore]
        public CharacterCharacteristicsInformations CharacterCharacteristicsInformations
        {
            get
            {
                return new CharacterCharacteristicsInformations(Exp,
                    ExperienceManager.Instance.Get(Enums.ExperienceEnum.Character, Level),
                    ExperienceManager.Instance.Get(Enums.ExperienceEnum.Character, Level + 1),
                    0, 0, (uint)StatsPoints, 0, (uint)SpellPoints,
                    new ActorExtendedAlignmentInformations(),
                    (uint)Stats.Get(PlayerFields.Health).Total,
                    (uint)Stats.Get(PlayerFields.Health).Total,
                    10000,
                    10000,
                    Stats.Get(PlayerFields.AP).Total,
                    Stats.Get(PlayerFields.MP).Total,
                    Stats.Get(PlayerFields.Initiative).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.Prospecting).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.AP).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.MP).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.Strength).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.Vitality).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.Wisdom).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.Chance).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.Agility).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.Intelligence).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.Range).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.SummonLimit).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.DamageReflection).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.CriticalHit).CharacterBaseCharacteristic,
                    0,
                    Stats.Get(PlayerFields.CriticalMiss).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.HealBonus).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.DamageBonus).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.WeaponDamageBonus).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.DamageBonusPercent).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.TrapBonus).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.TrapBonusPercent).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.GlyphBonusPercent).CharacterBaseCharacteristic,
                    new CharacterBaseCharacteristic(0, 0, 0, 0, 0),
                    Stats.Get(PlayerFields.PermanentDamagePercent).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.TackleBlock).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.TackleEvade).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.APAttack).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.MPAttack).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.PushDamageBonus).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.CriticalDamageBonus).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.NeutralDamageBonus).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.EarthDamageBonus).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.WaterDamageBonus).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.AirDamageBonus).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.FireDamageBonus).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.DodgeAPProbability).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.DodgeMPProbability).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.NeutralResistPercent).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.EarthResistPercent).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.WaterResistPercent).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.AirElementReduction).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.FireResistPercent).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.NeutralElementReduction).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.EarthElementReduction).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.WaterElementReduction).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.AirElementReduction).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.FireElementReduction).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.PushDamageReduction).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.CriticalDamageReduction).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.PvpNeutralResistPercent).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.PvpEarthResistPercent).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.PvpWaterResistPercent).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.PvpAirResistPercent).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.PvpFireResistPercent).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.PvpNeutralElementReduction).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.PvpEarthElementReduction).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.PvpWaterElementReduction).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.PvpAirElementReduction).CharacterBaseCharacteristic,
                    Stats.Get(PlayerFields.PvpFireElementReduction).CharacterBaseCharacteristic,
                    new CharacterBaseCharacteristic(0, 0, 0, 0, 0),
                    new CharacterBaseCharacteristic(0, 0, 0, 0, 0),
                    new CharacterBaseCharacteristic(0, 0, 0, 0, 0),
                    new CharacterBaseCharacteristic(0, 0, 0, 0, 0),
                    new CharacterBaseCharacteristic(0, 0, 0, 0, 0),
                    new CharacterBaseCharacteristic(0, 0, 0, 0, 0),
                    new CharacterBaseCharacteristic(0, 0, 0, 0, 0),
                    new CharacterBaseCharacteristic(0, 0, 0, 0, 0),
                    new CharacterSpellModification[0], 0);
            }
        }

        [Ignore]
        public SpellItem[] SpellsItem => Spells.Select(x => x.SpellItem).ToArray();

        [Ignore]
        public StatFields Stats { get; set; }

        [Ignore]
        public uint MaxPod => (uint)(1000 + Level * 5 + Stats.Get(PlayerFields.Strength).Total * 10);
        [Ignore]
        public uint Pods => (uint)(Items.Sum(x => x.Weigth));
        [Ignore]
        public List<Item> Items => ItemsManager.Instance.Get(Id);
        [Ignore]
        public List<Job> Jobs => JobsManager.Instance.Get(Id);

        #endregion

        #region Funcs
        public void Init()
        {
            Stats = new StatFields(() => Level, Statistiques, (field) => ItemsStat(field));
        }
        public uint UpgradeStat(sbyte statId, uint points)
        {
            Stat stat;
            uint nbr = 0;
            List<List<uint>> breedInfos = new();
            switch ((StatsBoostTypeEnum)statId)
            {
                case StatsBoostTypeEnum.Strength:
                    breedInfos = Breed.statsPointsForStrength;
                    stat = Stats.Get(PlayerFields.Strength);
                    break;
                case StatsBoostTypeEnum.Vitality:
                    breedInfos = Breed.statsPointsForVitality;
                    stat = Stats.Get(PlayerFields.Vitality);
                    break;
                case StatsBoostTypeEnum.Wisdom:
                    breedInfos = Breed.statsPointsForWisdom;
                    stat = Stats.Get(PlayerFields.Wisdom);
                    break;
                case StatsBoostTypeEnum.Chance:
                    breedInfos = Breed.statsPointsForChance;
                    stat = Stats.Get(PlayerFields.Chance);
                    break;
                case StatsBoostTypeEnum.Agility:
                    breedInfos = Breed.statsPointsForAgility;
                    stat = Stats.Get(PlayerFields.Agility);
                    break;
                case StatsBoostTypeEnum.Intelligence:
                    breedInfos = Breed.statsPointsForIntelligence;
                    stat = Stats.Get(PlayerFields.Intelligence);
                    break;
                default:
                    return 0;
            }
            if (stat == null)
                return 0;
            for (int i = 0; i < breedInfos.Count; i++)
            {
                var limit = breedInfos[i][0];
                if(i + 1 < breedInfos.Count)
                    limit = breedInfos[i + 1][0];
                if (limit == 0)
                {
                    nbr += (uint)Math.Floor((double)points / breedInfos[i][1]);
                    points -= (uint)Math.Floor((double)points / breedInfos[i][1]);
                    break;
                }
                else if ((stat.Base + nbr) <= limit)
                {
                    var good = (stat.Base + nbr);
                    if (points > (limit - good) * breedInfos[i][1] && i != breedInfos.Count -1)
                    {
                        nbr += (uint)(limit - good);
                        points -= (uint)(limit - good) * breedInfos[i][1];
                        continue;
                    }
                    else
                    {
                        nbr += (uint)(points / breedInfos[i][1]);
                        points = 0;
                    }
                    nbr += (uint)Math.Floor((double)points / breedInfos[i][1]);
                    break;
                }
            }
            if (nbr > 0)
                stat.AddBase((int)nbr);
            return nbr;
        }
        public bool UpgradeSpell(int spellId, int spellLevel)
        {
            var spell = Spells.FirstOrDefault(x => x.SpellId == spellId);
            if (spell == null || (spellLevel == 6 && spell.Template.obtentionLevel + 100 <= Level))
                return false;
            if(spell.Level >= spellLevel)
            {
                spell.Level = spellLevel;
                SpellsManager.Instance.Save(spell);
            } else
            {
                int cost = 0;
                for (int i = 0; i < spellLevel - spell.Level; i++)
                    cost += spell.Level + i;
                if (cost <= SpellPoints)
                    spell.Level = spellLevel;
                SpellsManager.Instance.Save(spell);
            }
            return true;
        }
        public void Save()
        {
            Statistiques = Stats.ToString();
            Starter.DatabaseWorld.Save(this);
        }
        public void AddTitle(uint id)
        {
            if (Titles.Any(x => x.TitleId == id))
                return;
            Starter.DatabaseWorld.Save(new Title()
            {
                CharacterId = Id,
                TitleId = Id,
                Enable = false
            });
        }
        public void RemoveTitle(uint id)
        {
            var title = Titles.FirstOrDefault(x => x.TitleId == id);
            if(title != null)
                Starter.DatabaseWorld.Delete(title);
        }
        public bool SetTitle(uint id)
        {
            if (id <= 0)
            {
                var old = Titles.FirstOrDefault(x => x.Enable);
                if (old != null)
                {
                    old.Enable = false;
                    Starter.DatabaseWorld.Save(old);
                }
            }
            else
            {
                var @new = Titles.FirstOrDefault(x => x.TitleId == id);
                if (@new == null)
                    return false;
                var old = Titles.FirstOrDefault(x => x.Enable);
                if (old != null)
                {
                    old.Enable = false;
                    Starter.DatabaseWorld.Save(old);
                }
                @new.Enable = true;
                Starter.DatabaseWorld.Save(@new);
            }
            Map.Send(new GameContextRemoveElementMessage(Id));
            Map.Send(new GameRolePlayShowActorMessage(GameRolePlayCharacterInformations));
            return true;
        }
        public void AddOrnament(uint id)
        {
            if (Ornements.Any(x => x.OrnementId == id))
                return;
            Starter.DatabaseWorld.Save(new Ornement()
            {
                CharacterId = Id,
                OrnementId = Id,
                Enable = false
            });
        }
        public void RemoveOrnament(uint id)
        {
            var orn = Ornements.FirstOrDefault(x => x.OrnementId == id);
            if (orn != null)
                Starter.DatabaseWorld.Delete(orn);
        }
        public bool SetOrnament(uint id)
        {
            if(id <= 0)
            {
                var old = Ornements.FirstOrDefault(x => x.Enable);
                if(old != null)
                {
                    old.Enable = false;
                    Starter.DatabaseWorld.Save(old);
                }
            }
            else
            {
                var @new = Ornements.FirstOrDefault(x => x.OrnementId == id);
                if (@new == null)
                    return false;
                var old = Ornements.FirstOrDefault(x => x.Enable);
                if (old != null)
                {
                    old.Enable = false;
                    Starter.DatabaseWorld.Save(old);
                }
                @new.Enable = true;
                Starter.DatabaseWorld.Save(@new);
            }
            Map.Send(new GameContextRemoveElementMessage(Id));
            Map.Send(new GameRolePlayShowActorMessage(GameRolePlayCharacterInformations));
            return true;
        }
        public void AddEmote(uint id)
        {
            if (Emotes.Any(x => x.EmoteId == id))
                return;
            Starter.DatabaseWorld.Save(new Emote()
            {
                CharacterId = Id,
                EmoteId = Id
            });
        }
        public void RemoveEmote(uint id)
        {
            var emote = Emotes.FirstOrDefault(x => x.EmoteId == id);
            if (emote != null)
                Starter.DatabaseWorld.Delete(emote);
        }
        public Tuple<bool, Item> AddItem(int gid, int amount, bool isMax = false, int i = 0)
        {
            var item = new Item(gid, amount, Id, isMax);
            var old = Items.FirstOrDefault(x => x.Gid == item.Gid && item.EffectsS == x.EffectsS);
            if (old is null)
            {
                ItemsManager.Instance.Save(item);
                return new Tuple<bool, Item>(true, item);
            }
            old.Quantity += amount;
            ItemsManager.Instance.Save(old);
            return new Tuple<bool, Item>(false, old);
        }
        public ObjectErrorEnum Equip(Item item, CharacterInventoryPositionEnum pos)
        {
            switch (pos)
            {
                case CharacterInventoryPositionEnum.ACCESSORY_POSITION_HAT:
                    if ((ItemTypeEnum)item.Template.typeId != ItemTypeEnum.HAT)
                        return ObjectErrorEnum.CANNOT_EQUIP_HERE;
                    break;
                case CharacterInventoryPositionEnum.ACCESSORY_POSITION_CAPE:
                    if ((ItemTypeEnum)item.Template.typeId != ItemTypeEnum.CLOAK && (ItemTypeEnum)item.Template.typeId != ItemTypeEnum.BACKPACK)
                        return ObjectErrorEnum.CANNOT_EQUIP_HERE;
                    break;
                case CharacterInventoryPositionEnum.ACCESSORY_POSITION_BELT:
                    if ((ItemTypeEnum)item.Template.typeId != ItemTypeEnum.BELT)
                        return ObjectErrorEnum.CANNOT_EQUIP_HERE;
                    break;
                case CharacterInventoryPositionEnum.ACCESSORY_POSITION_BOOTS:
                    if ((ItemTypeEnum)item.Template.typeId != ItemTypeEnum.BOOTS)
                        return ObjectErrorEnum.CANNOT_EQUIP_HERE;
                    break;
                case CharacterInventoryPositionEnum.ACCESSORY_POSITION_AMULET:
                    if ((ItemTypeEnum)item.Template.typeId != ItemTypeEnum.AMULET)
                        return ObjectErrorEnum.CANNOT_EQUIP_HERE;
                    break;
                case CharacterInventoryPositionEnum.ACCESSORY_POSITION_SHIELD:
                    if ((ItemTypeEnum)item.Template.typeId != ItemTypeEnum.SHIELD)
                        return ObjectErrorEnum.CANNOT_EQUIP_HERE;
                    break;
                case CharacterInventoryPositionEnum.ACCESSORY_POSITION_WEAPON:
                    if ((ItemTypeEnum)item.Template.typeId != ItemTypeEnum.AXE && 
                        (ItemTypeEnum)item.Template.typeId != ItemTypeEnum.BOW &&
                        (ItemTypeEnum)item.Template.typeId != ItemTypeEnum.DAGGER &&
                        (ItemTypeEnum)item.Template.typeId != ItemTypeEnum.HAMMER &&
                        (ItemTypeEnum)item.Template.typeId != ItemTypeEnum.PICKAXE &&
                        (ItemTypeEnum)item.Template.typeId != ItemTypeEnum.SCYTHE &&
                        (ItemTypeEnum)item.Template.typeId != ItemTypeEnum.SHOVEL &&
                        (ItemTypeEnum)item.Template.typeId != ItemTypeEnum.SOUL_STONE &&
                        (ItemTypeEnum)item.Template.typeId != ItemTypeEnum.STAFF &&
                        (ItemTypeEnum)item.Template.typeId != ItemTypeEnum.SWORD &&
                        (ItemTypeEnum)item.Template.typeId != ItemTypeEnum.TOOL &&
                        (ItemTypeEnum)item.Template.typeId != ItemTypeEnum.WAND)
                        return ObjectErrorEnum.CANNOT_EQUIP_HERE;
                    break;
                case CharacterInventoryPositionEnum.ACCESSORY_POSITION_PETS:
                    if ((ItemTypeEnum)item.Template.typeId != ItemTypeEnum.PET)
                        return ObjectErrorEnum.CANNOT_EQUIP_HERE;
                    break;
                case CharacterInventoryPositionEnum.INVENTORY_POSITION_RING_LEFT:
                case CharacterInventoryPositionEnum.INVENTORY_POSITION_RING_RIGHT:
                    if ((ItemTypeEnum)item.Template.typeId != ItemTypeEnum.RING)
                        return ObjectErrorEnum.CANNOT_EQUIP_HERE;
                    break;
                case CharacterInventoryPositionEnum.INVENTORY_POSITION_DOFUS_1:
                case CharacterInventoryPositionEnum.INVENTORY_POSITION_DOFUS_2:
                case CharacterInventoryPositionEnum.INVENTORY_POSITION_DOFUS_3:
                case CharacterInventoryPositionEnum.INVENTORY_POSITION_DOFUS_4:
                case CharacterInventoryPositionEnum.INVENTORY_POSITION_DOFUS_5:
                case CharacterInventoryPositionEnum.INVENTORY_POSITION_DOFUS_6:
                    if ((ItemTypeEnum)item.Template.typeId != ItemTypeEnum.DOFUS)
                        return ObjectErrorEnum.CANNOT_EQUIP_HERE;
                    break;
                case CharacterInventoryPositionEnum.INVENTORY_POSITION_NOT_EQUIPED:
                    if(item.Position == CharacterInventoryPositionEnum.INVENTORY_POSITION_NOT_EQUIPED)
                        if ((ItemTypeEnum)item.Template.typeId != ItemTypeEnum.DOFUS)
                            return ObjectErrorEnum.CANNOT_EQUIP_TWICE;
                    break;
                default:
                    return ObjectErrorEnum.CANNOT_EQUIP_HERE;
            }
            if (item.Template.level > Level)
                return ObjectErrorEnum.LEVEL_TOO_LOW;
            if (item.Criterias.Any(x => !x.Value(Stats.Get(x.Key).Total)))
                return ObjectErrorEnum.CRITERIONS;

            return ObjectErrorEnum.SUCCESS;
        }

        public Tuple<Tuple<bool, Item>, int, int, JobExperience> Recolte(uint actionId, short age)
        {
            var skill = ObjectDataManager.Get<Common.Protocol.Data.Skill>(actionId);
            var item = ObjectDataManager.Get<Common.Protocol.Data.Item>(skill.gatheredRessourceItem);
            var job = Jobs.First(x => x.JobId == skill.parentJobId);
            var count = new Random().Next(1, 7 + ((int)(job.Level - skill.levelMin + 1) / 10));
            var supp = count * (age / 100);
            var datas = AddItem(item.id, count + supp);
            job.Exp += (int)((5 * 10) + skill.levelMin);
            Starter.DatabaseWorld.Save(job);
            return new Tuple<Tuple<bool, Item>, int, int, JobExperience>(datas, count, supp, job.JobExperience);
        }
        #endregion

        #region Movement
        [Ignore]
        public bool MoveIsFinish { get; set; } = true;
        private List<CellWithOrientation> _path;
        public uint _velocity = 0;
        public double _start;
        public double _endwait = 0d;
        private Task _timer;
        //private CancellationTokenSource _tokenSource2 = new CancellationTokenSource();
        //private CancellationToken _ct;
        public void StartMovement(List<CellWithOrientation> path)
        {
            _path = path;
            MoveIsFinish = false;
            _velocity = MovementVelocity.GetPathVelocity(path.GetRange(1, path.Count - 1), path.Count < 4 ? Enums.MovementTypeEnum.WALKING : Enums.MovementTypeEnum.RUNNING);
            var interval = _velocity;
            _start = Environment.TickCount;
            _endwait = _start + (_velocity) * 0.8;
            _timer = Task.Run(() =>
            {
                while (Environment.TickCount < _endwait)
                {
                    //if (_ct.IsCancellationRequested)
                    //{
                    //    // Clean up here, then...
                    //    _ct.ThrowIfCancellationRequested();
                    //}
                }
                MoveIsFinish = true;
                CellId = (short)_path.Last().Id;
                Direction = (DirectionsEnum)_path[_path.Count - 1].Orientation;
            });
        }

        public int StopMove()
        {
            //_tokenSource2.Cancel();
            var cell = MovementVelocity.GetCellByStop(_path, _path.Count < 4 ? Enums.MovementTypeEnum.WALKING : Enums.MovementTypeEnum.RUNNING, Environment.TickCount - _start);
            CellId = cell;
            Save();
            return cell;
        }

        #endregion
    }
}
