using MineCraft_Server_Maneger.Models;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Remote
{
	class HostClientInterface
	{
		private readonly RemoteClient client;
		private string readCache = "";
		private bool isRunningCache = false;
		private DateTime lastIsRunningCacheUpdateTime;

		public HostClientInterface(IPAddress host, string password)
		{
			client = new RemoteClient(host, password);
			lastIsRunningCacheUpdateTime = DateTime.UtcNow;
		}


		public bool IsRunning
		{
			get
			{
				if((DateTime.UtcNow - lastIsRunningCacheUpdateTime).TotalSeconds >= 4) UpdateIsRunningCache();
				return isRunningCache;
			}
		}

		public ServerInfo ServerInfo => client.GetProperty<ServerInfo>(nameof(ServerInfo)).GetResult();

		public char ReadSimbol()
		{
			if (readCache.Length == 0)
				readCache += client.InvokeMethod<string>("ReadLine", new object[0]).GetResult();

			var tmp = readCache[0];
			readCache = readCache.Substring(1);

			return tmp;
		}

		public void Write(string s) => client.InvokeMethod(nameof(Write), new object[] { s }).GetResult();

		public void WriteLine(string s)
		{
			client.InvokeMethod(nameof(WriteLine), new object[] { s }).GetResult();
			UpdateIsRunningCache();
		}

		public void Launch()
		{
			client.InvokeMethod(nameof(Launch), new object[0]).GetResult();
			isRunningCache = true;
		}

		public void Kill()
		{
			client.InvokeMethod(nameof(Kill), new object[0]).GetResult();
			isRunningCache = false;
		}

		public void SetServerVersion(string name, string version) => client.InvokeMethod(nameof(SetServerVersion), new object[] { name, version }).GetResult();

		private void UpdateIsRunningCache()
		{
			isRunningCache = client.GetProperty<bool>(nameof(IsRunning)).GetResult();
			lastIsRunningCacheUpdateTime = DateTime.UtcNow;
		}
	}
}
