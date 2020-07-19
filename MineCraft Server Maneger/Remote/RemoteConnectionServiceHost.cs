using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Remote
{
	public class RemoteConnectionServiceHost
	{
		private readonly ServiceHost host;

		public RemoteConnectionServiceHost(string password)
		{
			host = new ServiceHost(new RemoteConnectionService(password));
		}


		public void Open()
		{
			host.Open();
		}

		public void Close()
		{
			host.Close();
		}


		~RemoteConnectionServiceHost()
		{
			Close();
		}
	}
}
