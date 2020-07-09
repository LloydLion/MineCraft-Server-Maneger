using MineCraft_Server_Maneger.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Actions
{
	class SetGamemodeFilterAction : ActionBase
	{
		public override string ActionName => "filter.gamemode";

		public override void Handler()
		{
			var form = new SetGamemodeFilterActionForm();
			form.ShowDialog();
			var r = form.Result;
			if (r == null) return;

			UIManeger.GlobalManeger.ListFilter.Type = UIManeger.PlayersFilter.FilterType.Gamemode;
			UIManeger.GlobalManeger.ListFilter.Argument = r.Gamemode;
		}
	}
}
