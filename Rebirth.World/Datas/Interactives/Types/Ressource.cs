using Rebirth.Common.Extensions;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.IStructures;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Managers;
using Rebirth.World.Models;
using System.Data;
using System.Timers;

namespace Rebirth.World.Datas.Interactives.Types
{
    public class Ressource : AbstractInteractive, IStatedElement
    {
        public uint[] ActionId
        {
            get;
        }
        public uint CellId
        {
            get;
            set;
        }
        public int Identifier
        {
            get;
            set;
        }
        public int Type
        {
            get;
        }
        public int ItemId
        {
            get;
        }
        public uint State
        {
            get;
            set;
        }
        public int MapId
        {
            get;
            set;
        }

        public short Age
        {
            get
            {
                var total = (DateTime.Now.DateTimeToUnixTimestampSeconds() - dateCreated) / 120 * 10;
                if (total > 200)
                    return 200;
                return (short)total;
            }
        }
        public bool IsOnMap
        {
            get;
            set;
        }

        public InteractiveElement GetInteractiveElement(Client client)
        {
            if (State == 0)
            {
                var test = new InteractiveElementWithAgeBonus(
                    Identifier,
                    Type,
                    (from x in ActionId
                     where client.Character.Jobs.Any(z => z.Skills.Any(y => y.id == x)) || x == 102
                     select new InteractiveElementSkill(x, 0)).ToArray(),
                    (from x in ActionId
                     where !client.Character.Jobs.Any(z => z.Skills.Any(y => y.id == x)) && x != 102
                     select new InteractiveElementSkill(x, 0)).ToArray(),
                    IsOnMap,
                    Age);
                return test;
            }

            else
                return new InteractiveElement(Identifier, Type, Array.Empty<InteractiveElementSkill>(), (from x in ActionId
                                                                                                 select new InteractiveElementSkill(x, 0)).ToArray(), IsOnMap);
        }

        public StatedElement GetStatedElement()
        {
            return new StatedElement(Identifier, CellId, State, true);
        }

        public bool Used;
        public Client ClientUser;
        private double dateCreated;
        private System.Timers.Timer _timer = new(3000);
        private System.Timers.Timer _timerRespawn = new(60000 * 5);

        public Ressource(int Identifier, uint CellId, int Type, uint[] ActionId, int MapId, bool onMap)
        {
            dateCreated = DateTime.Now.DateTimeToUnixTimestampSeconds();
            this.Identifier = Identifier;
            this.CellId = CellId;
            this.Type = Type;
            this.ActionId = ActionId;
            this.MapId = MapId;
            IsOnMap = onMap;
            _timer.Elapsed += TickAction;
            _timerRespawn.Elapsed += TickRespawn;
        }

        public void Use(Client client, uint skill)
        {
            if (!Used)
            {
                if (client.Character.Jobs.Any(z => z.Skills.Any(y => y.id == ActionId[0])) || ActionId[0] == 102)
                {
                    Map? map = MapsManager.Instance.Get(MapId);
                    if (map != null)
                    {
                        Used = true;
                        map.Send(new InteractiveUsedMessage((uint)client.Character.Id, (uint)Identifier, ActionId[0], 30, false));
                        _timer.Start();
                        ClientUser = client;
                    }
                }
                else
                {
                    client.Send(new InteractiveUseErrorMessage((uint)Identifier, ActionId[0]));
                }
            }
            else
            {
                client.Send(new InteractiveUseErrorMessage((uint)Identifier, ActionId[0]));
            }
        }

        public void TickAction(object sender, ElapsedEventArgs e)
        {
            (sender as System.Timers.Timer)?.Stop();
            State = 1;
            Map? map = MapsManager.Instance.Get(MapId);
            if (map != null)
            {
                map.UpdateInteractive(this);
                map.Send(new InteractiveUseEndedMessage((uint)Identifier, ActionId[0]));
            }
            _timerRespawn.Start();

            if (ActionId[0] != 102)
            {
                var result = ClientUser.Character.Recolte(ActionId[0], Age);
                if(result.Item3 <= 0)
                    ClientUser.Send(new ObtainedItemMessage((uint)result.Item1.Item2.Template.id, (uint)result.Item2));
                else
                    ClientUser.Send(new ObtainedItemWithBonusMessage((uint)result.Item1.Item2.Template.id, (uint)result.Item2, (uint)result.Item3));
                if (result.Item1.Item1)
                    ClientUser.Send(new ObjectAddedMessage(result.Item1.Item2.ObjectItem));
                else
                    ClientUser.Send(new ObjectModifiedMessage(result.Item1.Item2.ObjectItem));
                ClientUser.Send(new JobExperienceUpdateMessage(result.Item4));
            }
            else
            {
                Common.Protocol.Data.Item item = ObjectDataManager.Get<Common.Protocol.Data.Item>(311);
                int rdn = new Random().Next(1, 20);
                var datas = ClientUser.Character.AddItem(item.id, rdn);
                if (datas.Item1)
                    ClientUser.Send(new ObjectAddedMessage(datas.Item2.ObjectItem));
                else
                    ClientUser.Send(new ObjectModifiedMessage(datas.Item2.ObjectItem));
                ClientUser.Send(new ObtainedItemMessage((uint)item.id, (uint)rdn));
            }
        }

        public void TickRespawn(object sender, ElapsedEventArgs e)
        {
            (sender as System.Timers.Timer)?.Stop();
            Used = false;
            State = 0;
            Map? map = MapsManager.Instance.Get(MapId);
            map?.UpdateInteractive(this);
            dateCreated = DateTime.Now.DateTimeToUnixTimestampSeconds();
        }
    }
}
