using StandardLibrary.Interfaces;
using StandardLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Models
{
    class ServerCoreType : Model, IPrivateNamedObject
    {
        public ServerCoreType(bool isSupportPlugins, bool isSupportControlPlugin, string name,
            string properties, string opList, string banList, string pluginFolder)
        {
            IsSupportPlugins = isSupportPlugins;
            IsSupportControlPlugin = isSupportControlPlugin;
            Name = name;
            Paths = (properties, opList, banList, pluginFolder);
        }

        public bool IsSupportPlugins { get; set; }
        public bool IsSupportControlPlugin { get; set; }
        public string Name { get; set; }

        public (string properties, string opList, string banList, string pluginFolder) Paths { get; set; }

        public override object Clone()
        {
            return new ServerCoreType(IsSupportPlugins, IsSupportControlPlugin, Name,
                Paths.properties, Paths.opList, Paths.banList, Paths.pluginFolder);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
