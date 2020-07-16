using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Actions
{
	class OpenServerDirectoryAction : ActionBase
	{
		public override string ActionName => "other.open_server_directory";

		public override void Handler()
		{
			Process.Start("explorer.exe", Static.Path.data);
		}

		public override bool IsEnabled() => true;
	}
}
