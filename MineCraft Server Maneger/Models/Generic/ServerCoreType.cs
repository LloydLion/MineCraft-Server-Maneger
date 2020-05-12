using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Models.Generic
{
    class ServerCoreType
    {
        public ServerCoreType(bool isSupportPlugins, bool isSupportControlPlugin, string coreName,
            string properties, string opList, string banList, string pluginFolder)
        {
            IsSupportPlugins = isSupportPlugins;
            IsSupportControlPlugin = isSupportControlPlugin;
            CoreName = coreName;
            Paths = (properties, opList, banList, pluginFolder);
        }

        public ServerCoreType()
        {

        }

        /*public ServerCoreType(string s)
        {
            var t = s.Split('.');

            IsSupportPlugins = bool.Parse(t[0]);
            IsSupportControlPlugin = bool.Parse(t[1]);
            CoreName = t[2];
            Paths = (t[3], t[4], t[5], t[6]);
        }*/



        public bool IsSupportPlugins { get; set; }
        public bool IsSupportControlPlugin { get; set; }
        public string CoreName { get; set; }

        public (string properties, string opList, string banList, string pluginFolder) Paths { get; set; }

        public override string ToString()
        {
            //    return string.Join(".", IsSupportPlugins.ToString(), IsSupportControlPlugin.ToString(),
            //        CoreName, Paths.properties, Paths.opList, Paths.banList, Paths.pluginFolder);

            return CoreName;
        }
    }
}
