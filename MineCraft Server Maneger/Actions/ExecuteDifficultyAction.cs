using MineCraft_Server_Maneger.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Actions
{
    class ExecuteDifficultyAction : ActionBase
    {
        public override string ActionName => "commands.execute_difficulty";

        public override void Handler()
        {
            var form = new ExecuteDifficultyActionForm();
            form.ShowDialog();
            var r = form.Result;
            if (r == null) return;

            TimeSpan now = new TimeSpan(DateTime.Now.Ticks);
            ServerManeger.GlobalManeger.ChangeDifficulty(r.Difficulty, out var er);
            UIManeger.GlobalManeger.UpdateCommandOutput(er, now);
        }
    }
}
