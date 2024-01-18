using Rebirth.Common.Extensions;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Utils;
using Rebirth.World.Managers;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Command
{
    public class CommandManager : DataManager<CommandManager>
    {
        private List<CommandInterface> _commandes;
        public void Load()
        {
            _commandes = new List<CommandInterface>();
            var assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            for (int i = 0; i < types.Length; i++)
            {
                Type type = types[i];
                CommandAttribute customAttribute = type.GetCustomAttribute<CommandAttribute>();
                if (customAttribute != null)
                {
                    _commandes.Add(new CommandInterface() { Attribut = customAttribute, Type = type });
                }
            }
        }

        public void Execute(Client author, string msg)
        {
            var split = msg.Split(' ').ToList();

            var prefix = split[0]; // prefix de la command

            var command = _commandes.FirstOrDefault(i => i.Attribut.Aliases.Any(o => o == prefix));
            if (command == null)
            {
                author.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
                {
                    $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#e74c3c").ToArgb():X}\">Commande introuvable, tapez .help pour la liste des commandes.</font>"
                }));
                return;
            }

            if (author.Account.Role < command.Attribut.Role)
                return;

            var instance = (InGameCommand)Activator.CreateInstance(command.Type);

            if (instance.Parameters.FindAll(x => !x.IsOptionnal).Count > split.Count - 1)
            {
                author.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
                {
                   $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#e74c3c").ToArgb():X}\">Invalid command args.</font>"
                }));
                return;
            }

            if (split.Count > 1)
            {
                for (int i = 0; i < split.Count() - 1; i++)
                {
                    var value = split[i + 1];
                    instance.Parameters[i].Value = value;
                }
            }

            instance.Target = author;
            instance.Author = author;
            instance.Execute();

            var theRealTarget = instance.GetParameter<string>("Target");
            Console.WriteLine("[Command] {0} have launch {1} in {2}", instance.Author.Character.Name, prefix, (theRealTarget == "" ? instance.Target.Character.Name : theRealTarget));
        }
    }

    public class CommandInterface
    {
        public Type Type;
        public CommandAttribute Attribut;
    }
}
