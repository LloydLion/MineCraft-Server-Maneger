using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Models.Generic
{
    class Effect
    {
        public int Time { get; set; } = 30;
        public int Power { get; set; } = 1;
        public EffectType EffectType { get; set; }
        public bool HideParticiples { get; set; }
        public bool ClearEffects { get; set; }
    }
}
