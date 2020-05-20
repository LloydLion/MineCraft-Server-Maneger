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
    partial class ExecuteGiveActionForm : Form
    {
        public ExecuteGiveActionFormResult Result { get; private set; }

        private readonly Player[] players;
        private readonly ItemInfo[] items;

        public ExecuteGiveActionForm(Player[] players, ItemInfo[] items)
        {
            InitializeComponent();

            comboBoxPlayers.Items.AddRange(players.Select((s) => (object)s.Name).ToArray());
            comboBoxItems.Items.AddRange(items.Select((s) => (object)s.DisplayName).ToArray());

            this.players = players;
            this.items = items;
        }

        public class ExecuteGiveActionFormResult
        {
            public Player Player { get; set; }
            public ItemInfo Item { get; set; }
            public int Count { get; set; }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var f = items.Where((s) => s.DisplayName == comboBoxItems.Text).Single();
            var g = players.Where((s) => s.Name == comboBoxPlayers.Text).Single();

            f.Meta = int.Parse(textBoxMeta.Text);

            Result = new ExecuteGiveActionFormResult()
            {
                Player = g,
                Item = f,
                Count = int.Parse(textBoxCount.Text)
            };

            this.Close();
        }
    }
}
