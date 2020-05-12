using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineCraft_Server_Maneger.Actions
{
    class RestartServerAction : ActionBase
    {
        public override string ActionName => "common.restart_server";

        public override void Handler()
        {
            ServerManeger.GlobalManeger.Stop();
            ServerManeger.GlobalManeger.Start();
            MessageBox.Show("Server has restarted");
        }
    }
}
