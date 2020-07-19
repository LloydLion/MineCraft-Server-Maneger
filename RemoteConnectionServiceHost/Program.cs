using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteConnectionServiceHost
{
	class Program
	{
		static void Main(string[] args)
		{
			var host = new MineCraft_Server_Maneger.Remote.RemoteConnectionServiceHost("asd");
			host.Open();

			Console.WriteLine("Host Started...");

			Console.WriteLine("Press ANY key to close");
			host.Close();

			Console.ReadKey();
		}
	}
}
