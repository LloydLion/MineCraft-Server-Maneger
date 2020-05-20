﻿using MineCraft_Server_Maneger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Models.Generic
{
    class ItemInfo : IDoubleIndicatedElement
    {
        public string DisplayName { get; set; }
        public int NumId { get; set; }
        public string Id { get; set; }
        public int? Meta { get; set; }
    }
}