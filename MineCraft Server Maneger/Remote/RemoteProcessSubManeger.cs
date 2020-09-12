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
		private readonly HostClientInterface service;
		private readonly ServerIOInterface ioInterface;

		public RemoteProcessSubManeger(HostClientInterface service)
		{
			this.service = service;

			ioInterface = new ServerIOInterface(service.ReadSimbol, service.Write, service.WriteLine);
		}

		public override bool IsRunning => service.IsRunning;

		public override ServerIOInterface Interface => ioInterface;

		public override void Kill() => service.Kill();

		public override void Launch() => service.Launch();
	}
}
