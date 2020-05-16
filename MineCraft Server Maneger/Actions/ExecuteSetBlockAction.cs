using MineCraft_Server_Maneger.Forms;
using MineCraft_Server_Maneger.Models.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Actions
{
    class ExecuteSetBlockAction : ActionBase
    {
        public override string ActionName => "commands.execute_setblock";

        public override void Handler()
        {
            var form = new ExecuteSetBlockActionForm
                (ServerManeger.GlobalManeger.AvailableBlocks);

            form.ShowDialog();

            var result = form.Result;
            if (result == null) return;

            TimeSpan now = new TimeSpan(DateTime.Now.Ticks);
            ServerManeger.GlobalManeger.SetBlock(result.Block, result.Cords, out var er);
            UIManeger.GlobalManeger.UpdateCommandOutput(er, now);
        }
    }
}
