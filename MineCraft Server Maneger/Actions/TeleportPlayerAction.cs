using MineCraft_Server_Maneger.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Actions
{
	class TeleportPlayerAction : ActionBase
	{
		public override string ActionName => "actions.tp_player";

		public override void Handler()
		{
			var selectedPlayerSave = UIManeger.GlobalManeger.SelectedPlayer;

			var form = new TeleportPlayerActionForm(ServerManeger.GlobalManeger.OnlinePlayers);
			form.ShowDialog();
			var r = form.Result;
			if (r == null) return;

			TimeSpan now = new TimeSpan(DateTime.Now.Ticks);
			string er;

			if(r.IsToPlayer)
				ServerManeger.GlobalManeger.TeleportPlayer(selectedPlayerSave, r.Target, out er);
			else 
				ServerManeger.GlobalManeger.TeleportPlayer(selectedPlayerSave, r.Position, out er);
			

			UIManeger.GlobalManeger.UpdateCommandOutput(er, now);
		}
	}
}
