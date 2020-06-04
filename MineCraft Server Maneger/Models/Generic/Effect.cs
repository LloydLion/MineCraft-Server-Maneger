using StandardLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Models.Generic
{
    class Effect : Model
    {
        public Effect(int time, int power, EffectType effectType, bool hideParticiples, bool clearEffects)
        {
            Time = time;
            Power = power;
            EffectType = effectType;
            HideParticiples = hideParticiples;
            ClearEffects = clearEffects;
        }

        public int Time { get; }
        public int Power { get; }
        public EffectType EffectType { get; }
        public bool HideParticiples { get; }
        public bool ClearEffects { get; }

        public override object Clone()
        {
            return new Effect(Time, Power, EffectType, HideParticiples, ClearEffects);
        }
    }
}
