using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger
{
	class ServerIOInterface
	{
		private readonly Func<char> readSimbol;
		private readonly Action<string> write;
		private readonly Action<string> writeLine;


		public ServerIOInterface(Func<char> readSimbol, Action<string> write, Action<string> writeLine)
		{
			this.readSimbol = readSimbol;
			this.write = write;
			this.writeLine = writeLine;
		}


		public char ReadSimbol() => readSimbol();

		public void Write(string s) => write(s);

		public void WriteLine(string s) => writeLine(s);
	}
}
