using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StandardLibrary.Interfaces;
using StandardLibrary.Models;

namespace MineCraft_Server_Maneger.Models.Generic
{
    class Command : Model
    {
        public Command(string name, params object[] arguments)
        {
            Name = name;
            Arguments = arguments.Select((q) => q.ToString()).ToArray();
        }

        public string Name { get; }
        public string[] Arguments { get; }


        public override object Clone()
        {
            return new Command(Name, Arguments);
        }

        public override string ToString()
        {
            return Name + " " + string.Join(" ", Arguments);
        }
    }
}
