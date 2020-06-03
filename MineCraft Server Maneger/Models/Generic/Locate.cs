using MineCraft_Server_Maneger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Models.Generic
{
    class Locate : INamedObject, IIndicatedElement
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
