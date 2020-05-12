using MineCraft_Server_Maneger.Models.Generic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineCraft_Server_Maneger
{
    class UIManeger
    {
        public static UIManeger GlobalManeger { get; private set; }

        private readonly TextBox commandOutputTextBox;
        private readonly TextBox commandInputTextBox;
        private readonly ListView playersListView;

        public UIManeger(TextBox commandOutputTextBox, TextBox commandInputTextBox, ListView playersListView)
        {
            this.commandOutputTextBox = commandOutputTextBox;
            this.commandInputTextBox = commandInputTextBox;
            this.playersListView = playersListView;

            if (GlobalManeger == null) GlobalManeger = this;
        }

        public Player[] ListedPlayers 
        { 
            get
            {
                var g = playersListView.Items;
                var t = g.Cast<ListViewItem>();
                var h = t.Select((s) => s.Text);
                var p = h.Select((s) => ServerManeger.GlobalManeger.GetPlayerByName(s, false)).ToArray();

                return p;
            } 
        }

        public Player SelectedPlayer
        {
            get => ServerManeger.GlobalManeger.GetPlayerByName(playersListView.SelectedItems[0].Text);
        }

        public void UpdateCommandOutput(string a, TimeSpan startTime) =>
            UpdateCommandOutput(a, startTime, new TimeSpan(DateTime.Now.Ticks));

        public void UpdateCommandOutput(string a, TimeSpan timeStart, TimeSpan timeEnd)
        {
            var t = new string('-', 40);
            var h = (timeEnd - timeStart).TotalSeconds;
            h = Math.Round(h, 4);
            var spl = h.ToString().Split(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0])[1].Length;
            var swl = spl == 4 ? "" : new string('0', 4 - spl);
            var q = $"[{timeStart:hh\\:mm\\:ss}] -- [{timeEnd:hh\\:mm\\:ss}] ({h}{swl})";
            CommandOutput += $"\r\n{t}{q}{t}\r\n{a}\r\n";
        }

        public string CommandOutput { get => commandOutputTextBox.Text; set => commandOutputTextBox.Text = value; }
        public string CommandInput { get => commandInputTextBox.Text; private set => commandInputTextBox.Text = value; }
    }
}
