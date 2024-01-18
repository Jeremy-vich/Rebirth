using Rebirth.Common.GameData.D2I;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.GameData.Elements.Test;
using Rebirth.Common.GameData.Maps;
using Rebirth.Common.GameData.Maps.Elements;
using Rebirth.Common.IO;
using Rebirth.Common.Network;
using Rebirth.Common.Protocol.Data;
using Rebirth.World.Datas.Interactives.Types.Classic;
using Rebirth.World.Datas.Interactives.Types;
using Rebirth.World.Managers;
using System.Net.Security;
using Rebirth.World.Models;
using System.Diagnostics;

namespace Rebirth
{
    internal class Program
    {
        static List<InteractiveData> interactive = new();
        static void Main(string[] args)
        {
            Console.WriteLine("  ___     _    _     _   _    \r\n | _ \\___| |__(_)_ _| |_| |_  \r\n |   / -_) '_ \\ | '_|  _| ' \\ \r\n |_|_\\___|_.__/_|_|  \\__|_||_|\r\n                              ");
            Console.WriteLine("     -- Version 0.1b --\r\n");

            MessageReceiver.Initialize();
            Console.WriteLine("NetworkMessage Loaded !");
            ProtocolTypeManager.Initialize();
            Console.WriteLine("NetworkType Loaded !");
            ObjectDataManager.Initialize(@".\Datas\common");
            Console.WriteLine("ObjectData Loaded !");
            Common.GameData.Maps.MapsManager.Initialize(@".\Datas\maps");
            Console.WriteLine("Maps Loaded !");
            I18nDataManager.Instance.AddReaders(@".\Datas\i18n");

            Auth.Starter auth = new();
            auth.Start();

            World.Starter world = new();
            world.Start(1);

            Console.Read();
            Environment.Exit(0);
        }
    }
}