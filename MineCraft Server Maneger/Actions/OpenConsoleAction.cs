using MineCraft_Server_Maneger.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Actions
{
	class OpenConsoleAction : ActionBase
	{
		private OpenConsoleActionForm form;

		public override string ActionName => "other.open_console";

		public override void Handler()
		{
			if (form == null || form.IsDisposed)
			{
				form = new OpenConsoleActionForm(ServerManeger.GlobalManeger.ConsoleManeger);
				form.Show();
			}
		}
	}
}
