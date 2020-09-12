using MineCraft_Server_Maneger.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Remote
{
	class HostClientInteractor
	{
		private readonly LocalProcessSubManeger local = new LocalProcessSubManeger("core.jar", "", Static.Path.data);


		public HostClientInteractor()
		{
			
		}


		[RemoteInteract]
		public bool IsRunning => local.IsRunning;

		[RemoteInteract]
		public ServerInfo ServerInfo => JsonConvert.DeserializeObject<ServerInfo>(File.ReadAllText(Static.Path.data + "\\meta.meta"));

		[RemoteInteract]
		public string ReadLine()
		{
			var builder = new StringBuilder();

			var thread = new Thread(new ThreadStart(() =>
			{
				while (true)
				{
					var g = local.Interface.ReadSimbol();
					builder.Append(g);
					if (g == '\n') break;
				}
			}));

			thread.Start();

			Stopwatch watch = new Stopwatch();
			watch.Start();

			while(thread.IsAlive && watch.ElapsedMilliseconds <= 3_000) { }

			if(thread.IsAlive) thread.Abort();
			watch.Stop();

			//Must return 1 simbol
			if(builder.Length == 0) builder.Append(local.Interface.ReadSimbol());

			return builder.ToString();
		}

		[RemoteInteract]
		public void Write(string s)
		{
			local.Interface.Write(s);
		}

		[RemoteInteract]
		public void WriteLine(string a)
		{
			local.Interface.WriteLine(a);
		}

		[RemoteInteract]
		public void Launch()
		{
			local.Launch();
		}

		[RemoteInteract]
		public void Kill()
		{
			local.Kill();
		}
	}
}
