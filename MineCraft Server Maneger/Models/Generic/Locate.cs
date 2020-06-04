using MineCraft_Server_Maneger.Interfaces;
using StandardLibrary.Interfaces;
using StandardLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Models.Generic
{
    class Locate : Model, IPrivateNamedObject, IMCIndicatedObject
    {
        public Locate(string mcStringId, string name)
        {
            MCStringId = mcStringId;
            Name = name;
        }

        public string MCStringId { get; set; }
        public string Name { get; set; }

        public override object Clone()
        {
            return new Locate(MCStringId, Name);
        }
    }
}
