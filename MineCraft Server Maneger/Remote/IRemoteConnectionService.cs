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
	[ServiceContract]
	interface IRemoteConnectionService
	{
		[OperationContract]
		StreamWriter GetAppStreamWriter();
		
		[OperationContract]
		StreamReader GetAppStreamReader();

		[OperationContract]
		void Launch();

		[OperationContract]
		void Kill();

		[OperationContract]
		bool GetIsRunning();

		[OperationContract]
		void SetTargetVersion(string name, string version);

		[OperationContract]
		void DownloadServer(string name, string link, string version);

		[OperationContract]
		ServerInfo[] AvariebleServers();
	}
}
