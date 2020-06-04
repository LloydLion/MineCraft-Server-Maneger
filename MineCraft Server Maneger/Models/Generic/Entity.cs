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
    class Entity : Model, IPrivateNamedObject, IMCIndicatedObject
    {
        public Entity(string mcStringId, string name)
        {
            MCStringId = mcStringId;
            Name = name;
        }

        public string MCStringId { get; }
        public string Name { get; }

        public override object Clone()
        {
            return new Entity(MCStringId, Name);
        }
    }
}
