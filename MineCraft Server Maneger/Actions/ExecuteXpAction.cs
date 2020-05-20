using MineCraft_Server_Maneger.Forms;
using MineCraft_Server_Maneger.Models.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Actions
{
    class ExecuteXpAction : ActionBase
    {
        public override string ActionName => "commands.execute_xp";

        public override void Handler()
        {
            var form = new ExecuteXpActionForm(ServerManeger.GlobalManeger.OnlinePlayers);
            form.ShowDialog();

            var r = form.Result;
            if (r == null) return;

            TimeSpan now = new TimeSpan(DateTime.Now.Ticks);
            ServerManeger.GlobalManeger.GiveXp(r.Player, r.Count, out var er, r.IsLeveled);
            UIManeger.GlobalManeger.UpdateCommandOutput(er, now);
        }
    }
}
