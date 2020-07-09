using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineCraft_Server_Maneger.Actions
{
	class SetOnlineFilterAction : ActionBase
	{
		public override string ActionName => "filter.online";

		public override void Handler()
		{
			var dialog = MessageBox.Show("Is Online? or Offline", "On/Off line", MessageBoxButtons.YesNo);
			if (dialog == DialogResult.None) return;

			UIManeger.GlobalManeger.ListFilter.Type = UIManeger.PlayersFilter.FilterType.Online;
			UIManeger.GlobalManeger.ListFilter.Argument = dialog == DialogResult.Yes ? 0 : -1;
		}
	}

	class SetWhitelistFilterAction : ActionBase
	{
		public override string ActionName => "filter.whitelist";

		public override void Handler()
		{
			var dialog = MessageBox.Show("Is Whitelist? or UnWhitelist",
				"(Un)Whitelist", MessageBoxButtons.YesNo);

			if (dialog == DialogResult.None) return;

			UIManeger.GlobalManeger.ListFilter.Type = UIManeger.PlayersFilter.FilterType.Whitelist;
			UIManeger.GlobalManeger.ListFilter.Argument = dialog == DialogResult.Yes ? 0 : -1;
		}
	}

	class SetFavoriteFilterAction : ActionBase
	{
		public override string ActionName => "filter.favorite";

		public override void Handler()
		{
			var dialog = MessageBox.Show("Is Favorite? or UnFavorite",
				"(Un)Favorite", MessageBoxButtons.YesNo);

			if (dialog == DialogResult.None) return;

			UIManeger.GlobalManeger.ListFilter.Type = UIManeger.PlayersFilter.FilterType.Favorite;
			UIManeger.GlobalManeger.ListFilter.Argument = dialog == DialogResult.Yes ? 0 : -1;
		}
	}

	class SetBannedFilterAction : ActionBase
	{
		public override string ActionName => "filter.banned";

		public override void Handler()
		{
			var dialog = MessageBox.Show("Is Banned? or UnBanned",
				"(Un)Banned", MessageBoxButtons.YesNo);

			if (dialog == DialogResult.None) return;

			UIManeger.GlobalManeger.ListFilter.Type = UIManeger.PlayersFilter.FilterType.Banned;
			UIManeger.GlobalManeger.ListFilter.Argument = dialog == DialogResult.Yes ? 0 : -1;
		}
	}

	class SetOperatorFilterAction : ActionBase
	{
		public override string ActionName => "filter.operator";

		public override void Handler()
		{
			var dialog = MessageBox.Show("Is Operator? or DeOperator",
				"(De)Operator", MessageBoxButtons.YesNo);

			if (dialog == DialogResult.None) return;

			UIManeger.GlobalManeger.ListFilter.Type = UIManeger.PlayersFilter.FilterType.Operator;
			UIManeger.GlobalManeger.ListFilter.Argument = dialog == DialogResult.Yes ? 0 : -1;
		}
	}
}
