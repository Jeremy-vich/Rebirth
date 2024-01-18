using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Command
{
    public class CommandAttribute : Attribute
    {
        public string[] Aliases
        {
            get;
            protected set;
        }

        public string Description
        {
            get;
            set;
        }

        public bool Targetset
        {
            get;
            protected set;
        }

        public CharacterRoleEnum Role
        {
            get;
            protected set;
        }

        public Character Author
        { get; set; }
        public CommandAttribute(string[] aliases, string description, CharacterRoleEnum role, bool targetSet = false)
        {
            Aliases = aliases;
            Description = description;
            Role = role;
            Targetset = targetSet;
        }
    }
}
