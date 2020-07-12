using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Actions
{
	class BanPlayerAtion : ActionBase
	{
		public override string ActionName => "actions.ban_player";

		public override void Handler()
		{
			TimeSpan now = new TimeSpan(DateTime.Now.Ticks);
			ServerManeger.GlobalManeger.ToggleBanStatusForPlayer(UIManeger.GlobalManeger.SelectedPlayer, out var er);
			UIManeger.GlobalManeger.UpdateCommandOutput(er, now);
		}
	}
	class KickPlayerAction : ActionBase
	{
		public override string ActionName => "actions.kick_player";

		public override void Handler()
		{
			TimeSpan now = new TimeSpan(DateTime.Now.Ticks);
			ServerManeger.GlobalManeger.KickPlayer(UIManeger.GlobalManeger.SelectedPlayer, out var er);
			UIManeger.GlobalManeger.UpdateCommandOutput(er, now);
		}
	}
	class KillPlayerAction : ActionBase
	{
		public override string ActionName => "actions.kill_player";

		public override void Handler()
		{
			TimeSpan now = new TimeSpan(DateTime.Now.Ticks);
			ServerManeger.GlobalManeger.KillPlayer(UIManeger.GlobalManeger.SelectedPlayer, out var er);
			UIManeger.GlobalManeger.UpdateCommandOutput(er, now);
		}
	}

	class ChangePlayerOperatorStatusAction : ActionBase
	{
		public override string ActionName => "actions.op_player";

		public override void Handler()
		{
			TimeSpan now = new TimeSpan(DateTime.Now.Ticks);
			ServerManeger.GlobalManeger.ToggleOperatorStatusForPlayer(UIManeger.GlobalManeger.SelectedPlayer, out var er);
			UIManeger.GlobalManeger.UpdateCommandOutput(er, now);
		}
	}
}
