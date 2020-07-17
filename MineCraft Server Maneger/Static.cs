using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger
{
    static class Static
    {
        public static (string server, string binaries, string data, string world) Path { get; } =
        (
            Environment.CurrentDirectory + "\\Core\\server",
            Environment.CurrentDirectory + "\\Core\\bin",
            Environment.CurrentDirectory + "\\Core\\data",
            Environment.CurrentDirectory + "\\Core\\world"
        );

        public const string LinesSeparator = "\r\n";
    }
}
