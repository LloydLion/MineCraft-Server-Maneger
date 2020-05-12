using MineCraft_Server_Maneger.Forms;
using MineCraft_Server_Maneger.Models.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Actions
{
    class ExecuteGameruleAction : ActionBase
    {
        public override string ActionName => "commands.execute_gamerule";

        public override void Handler()
        {
            var ag = ServerManeger.GlobalManeger.AvailableGamerules;
            var form = new ExecuteGameruleActionForm(ag);
            form.ShowDialog();
            var r = form.Result;
            if (r == null) return;

            TimeSpan now = new TimeSpan(DateTime.Now.Ticks);
            if (r.IsSet)
            {
                ServerManeger.GlobalManeger.SetGamerule(r.Selected, r.Value, out var outr);
                UIManeger.GlobalManeger.UpdateCommandOutput(outr + ": " + r.Value.ToString(), now);
            }
            else
            {
                UIManeger.GlobalManeger.UpdateCommandOutput
                    (r.Selected.Name + " = " + ServerManeger.GlobalManeger.GetGamerule(r.Selected).ToString(), now);
            }
        }
    }
}
