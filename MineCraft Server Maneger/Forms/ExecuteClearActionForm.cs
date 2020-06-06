using MineCraft_Server_Maneger.Models.Generic;
using StandardLibrary.Collections;
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
    partial class ExecuteClearActionForm : Form
    {
        public class ExecuteClearActionFormResult
        { 
            public Player Player { get; set; }
        
        }

        public ExecuteClearActionFormResult Result { get; private set; }

        private readonly Player[] players;

        public ExecuteClearActionForm(Player[] players)
        {
            InitializeComponent();
            this.players = players;

            comboBox.Items.AddRange(players.Select((s) => s.Name).Cast<object>().ToArray());
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Result = new ExecuteClearActionFormResult
            {
                Player = players.Where((s) => s.Name == comboBox.Text).Single()
            };

            this.Close();
        }
    }
}
