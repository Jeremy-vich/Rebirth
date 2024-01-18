using Rebirth.Common.Extensions;
using Rebirth.World.Datas.Events;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Managers
{
    public class EventsManager : DataManager<EventsManager>
    {
        private List<SmileyEvent> _smileyEvents = new List<SmileyEvent>();
    
        public void AddSmileyEvent(Client client) => _smileyEvents.Add(new SmileyEvent(client));
    }
}
