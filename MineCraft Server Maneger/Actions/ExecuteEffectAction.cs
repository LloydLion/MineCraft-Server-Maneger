using MineCraft_Server_Maneger.Models.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineCraft_Server_Maneger.Actions
{
    class ExecuteEffectAction : ActionBase
    {


        public override string ActionName => "commands.execute_effect";

        public override void Handler()
        {
            

            var dialog = new Forms.ExecuteEffectActionForm(
                
            ServerManeger.GlobalManeger.OnlinePlayers.Select((s) => s.Name).ToArray(), 
            
            UIManeger.GlobalManeger.ListedPlayers.Select((g) => g.Name).ToArray(), 

            new string[]
            {

            });

            dialog.ShowDialog();
            var result = dialog.Result;

            if (result == null) return;

            StringBuilder resultBuilder = new StringBuilder();
            TimeSpan n = new TimeSpan(DateTime.Now.Ticks);
            foreach (var item in result.Entities)
            {
                resultBuilder.AppendLine(string.Join("\r\n",
                    ServerManeger.GlobalManeger.ApplyEffectsToEntity(item, result.Effect)));
            }

            resultBuilder = resultBuilder.Remove(resultBuilder.Length - 2, 2);

            UIManeger.GlobalManeger.UpdateCommandOutput(resultBuilder.ToString(), n);
        }

        public override bool IsEnabled()
        {
            return ServerManeger.GlobalManeger.MCVersion > new MCVersion("1.7.10") && base.IsEnabled();
        }
    }
}
 