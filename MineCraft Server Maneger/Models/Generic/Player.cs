﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Models.Generic
{
    class Player : Entity
    {
        public List<PlayerTag> Tags { get; } = new List<PlayerTag>();

        public enum PlayerTag
        {
            Operator,
            Banned,
            Online,
            Whitelisted,
        }
    }
}
