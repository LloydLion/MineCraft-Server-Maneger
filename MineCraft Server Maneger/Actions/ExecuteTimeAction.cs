using MineCraft_Server_Maneger.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Actions
{
    class ExecuteTimeAction : ActionBase
    {
        public override string ActionName => "commands.execute_time";

        public override void Handler()
        {
            var f = new ExecuteTimeActionForm();
            f.ShowDialog();
            var r = f.Result;
            if (r == null) return;

            var s = new TimeSpan(DateTime.Now.Ticks);
            if(r.MainCommand == "Set")
            {
                UIManeger.GlobalManeger.UpdateCommandOutput(ServerManeger.GlobalManeger.SetTime(r.Time), s);
            }
            else
            {
                UIManeger.GlobalManeger.UpdateCommandOutput(ServerManeger.GlobalManeger.AddTime(r.Time), s);
            }
        }
    }
}
