using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineCraft_Server_Maneger.Actions
{
    class StopServerAction : ActionBase
    {
        public override string ActionName => "common.stop_server";

        public override void Handler()
        {
            ServerManeger.GlobalManeger.Stop();
            ServerStade.IsRunnning = false;
            MessageBox.Show("Server has stopped");
        }
    }
}
