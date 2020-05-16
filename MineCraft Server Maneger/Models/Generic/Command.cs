using MineCraft_Server_Maneger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Models.Generic
{
    class Command : INamedObject
    {
        public Command(string name, params string[] arguments)
        {
            Name = name;
            Arguments = arguments;
        }

        public string Name { get; set; }
        public string[] Arguments { get; set; }

        public override string ToString()
        {
            return Name + " " + string.Join(" ", Arguments);
        }
    }
}
