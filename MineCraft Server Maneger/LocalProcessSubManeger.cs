using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger
{
    public class LocalProcessSubManeger : ProcessSubManeger
    {
        private readonly Process serverProcess;

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
                    RedirectStandardOutput = true,
                }
            };
        }

        public override bool IsRunning => !serverProcess.HasExited;
        public override StreamWriter AppStreamWriter => serverProcess.StandardInput;
        public override StreamReader AppStreamReader => serverProcess.StandardOutput;

        public override void Launch()
        {
            serverProcess.Start();
        }

        public override void Kill()
        {
            serverProcess.Kill();
        }
    }
}
