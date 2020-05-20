using MineCraft_Server_Maneger.Forms;
using MineCraft_Server_Maneger.Models.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Actions
{
    class ExecuteGiveAction : ActionBase
    {
        public override string ActionName => "commands.execute_give";

        public override void Handler()
        {
            var form = new ExecuteGiveActionForm(ServerManeger.GlobalManeger.OnlinePlayers,
                ServerManeger.GlobalManeger.AvailableItems);

            form.ShowDialog();
            var r = form.Result;
            if (r == null) return;

            TimeSpan now = new TimeSpan(DateTime.Now.Ticks);
            ServerManeger.GlobalManeger.GiveItem(r.Item, r.Player, r.Count, out var er);
            UIManeger.GlobalManeger.UpdateCommandOutput(er, now);
        }
    }
}
