using MineCraft_Server_Maneger.Models.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Models
{
    class ServerInfo
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public MCVersion GameVersion { get; set; }
        public ServerCoreType CoreType { get; set; }


        public ServerInfo Clone()
        {
            var ti = typeof(ServerInfo);
            var pi = ti.GetProperties();
            var newObj = new ServerInfo();

            foreach (var item in pi)
            {
                item.SetValue(newObj, item.GetValue(this));
            }

            return newObj;
        }

        //protected T FormatSuper<T>(params object[] args) where T : new()
        //{
        //    var ti = typeof(T);
        //    var pi = ti.GetProperties().Where((d) => d.PropertyType == typeof(string));
        //    var t = new object[byte.MaxValue];
        //    var newObj = new T();

        //    for (int i = 0; i < args.Length; i++)
        //        t[i] = args[i];

        //    t = t.Select((g, i) => g ?? "{" + i + "}").ToArray();

        //    foreach (var item in pi)
        //    {
        //        item.SetValue(newObj, string.Format((string)item.GetValue(this), t));
        //    }

        //    return newObj;
        //}

        //public virtual ServerInfo Format(params object[] args)
        //{
        //    return FormatSuper<ServerInfo>(args);
        //}

        public virtual void Format(params object[] args)
        {
            args = PrepareArrayForFormatMethod(args);
            Name = string.Format(Name, args);
            Path = string.Format(Path, args);
            GameVersion.Version = string.Format(GameVersion.Version, args);
            CoreType.Name = string.Format(CoreType.Name, args);

            var p = CoreType.Paths;

            p.opList = string.Format(p.opList, args);
            p.pluginFolder = string.Format(p.pluginFolder, args);
            p.properties = string.Format(p.properties, args);
            p.banList = string.Format(p.banList, args);
        }

        public void Init()
        {
            GameVersion.Init();
        }

        protected object[] PrepareArrayForFormatMethod(object[] args)
        {
            var o = new object[256];

            for (int i = 0; i < args.Length; i++)
                o[i] = args[i];
            
            o = o.Select((f, i) => f ?? "{" + i + "}").ToArray();
            return o;
        }
    }
}
