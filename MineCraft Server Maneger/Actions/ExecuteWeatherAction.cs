using MineCraft_Server_Maneger.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Actions
{
    class ExecuteWeatherAction : ActionBase
    {
        public override string ActionName => "commands.execute_weather";

        public override void Handler()
        {
            var form = new ExecuteWeatherActionForm();
            form.ShowDialog();
            var r = form.Result;
            if (r == null) return;

            TimeSpan now = new TimeSpan(DateTime.Now.Ticks);
            ServerManeger.GlobalManeger.ChangeWeather(r.WeatherStade, out var er);
            UIManeger.GlobalManeger.UpdateCommandOutput(er, now);
        }
    }
}
