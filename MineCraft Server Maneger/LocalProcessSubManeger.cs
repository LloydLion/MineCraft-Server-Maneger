using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger
{
    class LocalProcessSubManeger : ProcessSubManeger
    {
        private readonly Process serverProcess;
        private ServerIOInterface ioInterface;

        public LocalProcessSubManeger(string pathToJar, string javaPath, string workingDirectory)
        {
            serverProcess = new Process()
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = $"{javaPath}javaw.exe",
                    Arguments = $"-jar {pathToJar}",
                    WorkingDirectory = workingDirectory,

                    UseShellExecute = false,
                    RedirectStandardError = true,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true
                }
            };

            ioInterface = new ServerIOInterface(null, null, null);
        }

        public override bool IsRunning => serverProcess.IsRunning();

		public override ServerIOInterface Interface => ioInterface;

		public override void Launch()
        {
            serverProcess.Start();
            ioInterface = new ServerIOInterface(() => (char)serverProcess.StandardOutput.Read(), serverProcess.StandardInput.Write, serverProcess.StandardInput.WriteLine);
            InterfaceChanged?.Invoke();
        }

        public override void Kill()
        {
            serverProcess.Kill();
            ioInterface = new ServerIOInterface(null, null, null);
            InterfaceChanged?.Invoke();
        }


        public event Action InterfaceChanged;
    }
}
