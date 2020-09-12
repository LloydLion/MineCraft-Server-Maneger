using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger
{
    abstract class ProcessSubManeger
    {
        public abstract void Launch();

        public abstract void Kill();


        public abstract bool IsRunning { get; }

        public abstract ServerIOInterface Interface { get; }

        public static ProcessSubManeger StandardManeger { get => new LocalProcessSubManeger("core.jar", "", Static.Path.data); }
    }
}
