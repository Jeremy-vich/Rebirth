using Rebirth.Common.Extensions;
using Rebirth.World.Frames;
using Rebirth.World.Models;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Rebirth.World.Managers
{
    public class JailManager : DataManager<JailManager>
    {
        private Timer _timer = new();

        public void Init()
        {
            _timer.Elapsed += Execute;
            _timer.Interval = 10000;
            _timer.Start();
        }

        public void Execute(object sender, ElapsedEventArgs args)
        {
            var list = Starter.DatabaseAuth.Fetch<Account>("WHERE UnJail <= @0", DateTime.Now);
            foreach (var item in list)
            {
                var client = ClientsManager.Instance.Get(x => x.Account.Id == item.Id);
                if(client != null)
                {
                    client.Account.UnJail = null;
                    AccountManager.Instance.Save(client.Account);

                    client.AddFrame(typeof(InventoryFrame));
                    client.UnJail();
                }
                else
                {
                    item.UnJail = null;
                    AccountManager.Instance.Save(item);
                }
            }
        }

        public Tuple<int, int> GetMap() => new List<Tuple<int, int>>
        {
            new Tuple<int, int>(152324, 259),
            new Tuple<int, int>(154884, 230),
            new Tuple<int, int>(154627, 299),
            new Tuple<int, int>(152067, 127),
        }[new Random().Next(0, 4)];

        public bool IsInJail(int mapid) => mapid == 152324 || mapid == 154884 || mapid == 154627 || mapid == 152067;
    }
}
