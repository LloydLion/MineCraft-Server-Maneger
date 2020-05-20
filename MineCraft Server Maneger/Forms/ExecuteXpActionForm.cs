using MineCraft_Server_Maneger.Models.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineCraft_Server_Maneger.Forms
{
    partial class ExecuteXpActionForm : Form
    {
        readonly Player[] players;

        public ExecuteXpActionFormResult Result { get; private set; }

        public ExecuteXpActionForm(Player[] players)
        {
            InitializeComponent();
            this.players = players;

            comboBox.Items.AddRange(players.Select((s) => s.Name).Cast<object>().ToArray());
        }

        public class ExecuteXpActionFormResult
        {
            public Player Player { get; set; }
            public bool IsLeveled { get; set; }
            public int Count { get; set; }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Result = new ExecuteXpActionFormResult()
            {
                Player = players.Where((s) => s.Name == comboBox.Text).Single(),
                IsLeveled = checkBox.Checked,
                Count = (int)Math.Floor(numericUpDown.Value)
            };

            this.Close();
        }
    }
}
