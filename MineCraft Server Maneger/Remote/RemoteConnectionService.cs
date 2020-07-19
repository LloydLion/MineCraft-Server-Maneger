using MineCraft_Server_Maneger.Models;
using MineCraft_Server_Maneger.Models.Generic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MineCraft_Server_Maneger.Remote
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
	class RemoteConnectionService : IRemoteConnectionService
	{
		private readonly string password;

		public RemoteConnectionService(string password)
		{
			this.password = password;
		}


		public ServerInfo[] AvariebleServers()
		{
			return null;
		}

		public void DownloadServer(string name, ServerDownloadInfo info)
		{
			
		}

		public void DownloadServer(string name, string link, string version)
		{
			
		}

		public StreamReader GetAppStreamReader()
		{
			return null;
		}

		public StreamWriter GetAppStreamWriter()
		{
			return null;
		}

		public bool GetIsRunning()
		{
			return false;
		}

		public void Kill()
		{

		}

		public void Launch()
		{
			
		}

		public void SetTargetVersion(string name, string version)
		{

		}
	}
}
