using MineCraft_Server_Maneger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Models.Generic
{
    class EffectType : INamedObject, IDoubleIndicatedElement
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int NumId { get; set; }
        public bool IsPositive { get; set; }
        public List<EffectTypeTag> Tags { get; } = new List<EffectTypeTag>();

        public enum EffectTypeTag
        {
            OneLvlMax,
            Lvl127Max,
        }
    }
}
