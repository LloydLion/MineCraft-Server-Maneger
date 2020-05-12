using MineCraft_Server_Maneger.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineCraft_Server_Maneger
{
    abstract class ActionBase
    {
        public abstract string ActionName { get; }

        public ServerInfo ServerInfo { get; set; }
        public ServerStade ServerStade { get; set; }
        //public StreamWriter InputStream { get => ServerProcess.StandardInput; }
        //public StreamReader OutputStream { get => ServerProcess.StandardOutput; }
        //public Process ServerProcess { get; set; }
        public Control[] Controls { get; set; }

        public virtual bool IsEnabled() => ServerStade.IsSelected && ServerStade.IsRunnning;
        public abstract void Handler();
    }
}
