using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Models.Generic
{
    class Player : Entity
    {
        public Player(string name) : base("minecraft:player", name)
        {

        }

        public List<PlayerTag> Tags { get; } = new List<PlayerTag>();

        public override object Clone()
        {
            return new Player(Name);
        }

        public enum PlayerTag
        {
            Operator,
            Banned,
            Online,
            Whitelisted,
        }
    }
}
