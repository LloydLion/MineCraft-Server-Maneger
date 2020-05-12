using MineCraft_Server_Maneger.Forms;
using MineCraft_Server_Maneger.Models.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Actions
{
    class ExecuteSayAction : ActionBase
    {
        public override string ActionName => "commands.execute_say";

        public override void Handler()
        {
            var f = new ExecuteSayActionForm();
            f.ShowDialog();
            var r = f.Result;

            if (r == null) return;

            var t = new TimeSpan(DateTime.Now.Ticks); 
            var q = ServerManeger.GlobalManeger.Execute(new Command("say", r.Message));
            UIManeger.GlobalManeger.UpdateCommandOutput(q, t);
        }
    }
}
