using MineCraft_Server_Maneger.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineCraft_Server_Maneger.Actions
{
    class ExecuteLocateAction : ActionBase
    {
        public override string ActionName => "commands.execute_locate";

        public override void Handler()
        {
            var locates = ServerManeger.GlobalManeger.VersionManeger.AvailableLocates;
            var form = new ExecuteLocateActionForm(locates);
            form.ShowDialog();
            var r = form.Result;
            if (r == null) return;

            TimeSpan now = new TimeSpan(DateTime.Now.Ticks);
            (float x, float z) cords = ServerManeger.GlobalManeger.Locate(r.Locate);
            UIManeger.GlobalManeger.UpdateCommandOutput($"{cords.x} [y?] {cords.z}", now);
        }
    }
}
