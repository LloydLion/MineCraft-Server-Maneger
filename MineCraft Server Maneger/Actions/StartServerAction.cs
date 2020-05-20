using MineCraft_Server_Maneger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineCraft_Server_Maneger.Actions
{
    class StartServerAction : ActionBase
    {
        public override string ActionName => "common.start_server";
        public override void Handler()
        {
            ServerManeger.GlobalManeger.Start();
            ServerStade.IsRunnning = true;
            MessageBox.Show("Server is starting");
        }

        public override bool IsEnabled()
        {
            if (!ServerStade.IsSelected) return false;
            else return !ServerStade.IsRunnning;
        }
    }
}
