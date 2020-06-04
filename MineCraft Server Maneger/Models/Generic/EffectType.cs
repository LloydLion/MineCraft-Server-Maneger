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
    class EffectType : Model, IPrivateNamedObject, IMCDoubleIndicatedObject
    {
        public EffectType(string name, string mcStringId, int mcId, bool isPositive)
        {
            Name = name;
            MCStringId = mcStringId;
            MCId = mcId;
            IsPositive = isPositive;
        }

        public string Name { get; }
        public string MCStringId { get; }
        public int MCId { get; }
        public bool IsPositive { get; }
        public List<EffectTypeTag> Tags { get; } = new List<EffectTypeTag>();

        public override object Clone()
        {
            var obj = new EffectType(Name, MCStringId, MCId, IsPositive);

            obj.Tags.Clear();
            obj.Tags.AddRange(Tags);

            return obj;
        }

        public enum EffectTypeTag
        {
            OneLvlMax,
            Lvl127Max,
        }
    }
}
