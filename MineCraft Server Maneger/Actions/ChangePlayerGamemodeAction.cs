using MineCraft_Server_Maneger.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Actions
{
	class ChangePlayerGamemodeAction : ActionBase
	{
		public override string ActionName => "actions.gamemode_player";

		public override void Handler()
		{
			var form = new ChangePlayerGamemodeActionForm();
			form.ShowDialog();
			var r = form.Result;
			if (r == null) return;

			TimeSpan now = new TimeSpan(DateTime.Now.Ticks);
			ServerManeger.GlobalManeger.ChangePlayerGamemode(UIManeger.GlobalManeger.SelectedPlayer, r.SelectedGamemode, out var er);
			UIManeger.GlobalManeger.UpdateCommandOutput(er, now);
		}
	}
}
