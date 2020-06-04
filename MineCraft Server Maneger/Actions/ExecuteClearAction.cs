using MineCraft_Server_Maneger.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Actions
{
    class ExecuteClearAction : ActionBase
    {
        public override string ActionName => "commands.execute_clear";

        public override void Handler()
        {
            var form = new ExecuteClearActionForm(ServerManeger.GlobalManeger.OnlinePlayers);
            form.ShowDialog();
            var r = form.Result;
            if (r == null) return;

            TimeSpan now = new TimeSpan(DateTime.Now.Ticks);
            ServerManeger.GlobalManeger.Clear(r.Player, out var er);
            UIManeger.GlobalManeger.UpdateCommandOutput(er, now);
        }
    }
}
