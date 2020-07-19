using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Remote
{
	class RemoteProcessSubManeger : ProcessSubManeger
	{
		private IRemoteConnectionService service;

		public RemoteProcessSubManeger(IRemoteConnectionService service)
		{
			this.service = service;
		}

		public override bool IsRunning => service.GetIsRunning();

		public override StreamWriter AppStreamWriter => service.GetAppStreamWriter();

		public override StreamReader AppStreamReader => service.GetAppStreamReader();

		public override void Kill() => service.Kill();

		public override void Launch() => service.Launch();
	}
}
