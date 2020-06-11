using MineCraft_Server_Maneger.Models.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Actions
{
	class RunCommandAction : ActionBase
	{
		public override string ActionName => "commands.run";

		public override void Handler()
		{
			var tmp = UIManeger.GlobalManeger.CommandInput.Split(' ');
			var args = new string[tmp.Length - 1];
			var command = tmp[0];
			Array.Copy(tmp, 1, args, 0,args.Length);

			TimeSpan now = new TimeSpan(DateTime.Now.Ticks);
			var er = ServerManeger.GlobalManeger.Execute(new Command(command, args));
			UIManeger.GlobalManeger.UpdateCommandOutput(er, now);
		}
	}
}
