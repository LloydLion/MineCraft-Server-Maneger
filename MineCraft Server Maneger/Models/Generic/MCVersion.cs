using StandardLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Models.Generic
{
    class MCVersion : Model, IComparable
    {
        private int[] split;

        public string Version { get; set; }

        public MCVersion(string version, bool init = true)
        {
            Version = version;
            if (init) Init();
        }

        public static bool operator >(MCVersion left, MCVersion right) => right < left;
        public static bool operator <(MCVersion left, MCVersion right) => !(left >= right);
        public static bool operator >=(MCVersion left, MCVersion right) => right <= left;
        public static bool operator <=(MCVersion left, MCVersion right) => left.CompareTo(right) != 1;

        public static explicit operator MCVersion(string s)
        {
            return new MCVersion(s, false);
        }

        public override string ToString()
        {
            return Version;
        }

        public void Init()
        {
            var t = Version.Split('.');

            if ((t.Length == 3 || t.Length == 2) && t[0] == "1")
            {
                Version = Version;
                split = t.Select(int.Parse).ToArray();

                if (split.Length == 2)
                {
                    split = split.Append(0).ToArray();
                    Version += ".0";
                }
            }
            else
            {
                throw new Exception("Ivalid structure of version");
            }
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            if (obj is MCVersion asd)
            {
                var f = this.split[1].CompareTo(asd.split[1]);
                if (f != 0)
                    return f;
                else
                    return this.split[2].CompareTo(asd.split[2]);
            }
            else
                throw new ArgumentException("Object is not a Temperature");
        }

        public override object Clone()
        {
            return new MCVersion(Version, split != null);
        }
    }
}
