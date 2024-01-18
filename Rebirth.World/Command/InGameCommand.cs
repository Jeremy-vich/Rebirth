using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Command
{
    public abstract class InGameCommand
    {
        public Client Author { get; set; }
        public List<Parameter> Parameters = new List<Parameter>();
        public Client Target;
        public Character Character;

        public abstract void Execute();
        public T GetParameter<T>(string name)
        {
            try
            {
                var parameter = Parameters.FirstOrDefault(i => i.Name.ToLower() == name.ToLower());
                if (parameter == null)
                    return default(T);


                return (T)Convert.ChangeType(parameter.Value, typeof(T));
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        public void AddParameter(Parameter parameter)
        {
            Parameters.Add(parameter);
        }
        public void SetValueParameter(string name, object value)
        {
            Parameters.First(o => o.Name == name).Value = value;
        }

    }
}
