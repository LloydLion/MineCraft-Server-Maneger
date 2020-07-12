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

        public void Invoke(Delegate del)
        {
            commandOutputTextBox.Invoke
                (new Action(() => playersListView.Invoke
                (new Action(() => commandInputTextBox.Invoke(del)))));
        }

        public string CommandOutput { get => commandOutputTextBox.Text; set => commandOutputTextBox.Text = value; }
        public string CommandInput { get => commandInputTextBox.Text; private set => commandInputTextBox.Text = value; }
        public PlayersFilter ListFilter { get; set; } = new PlayersFilter();
        public List<Player> FavoritePlayers { get; }


        public class PlayersFilter
        {
            private FilterType type;

            public object Argument { get; set; }
            public FilterType Type { get => type; set { type = value; Argument = null; } }

            public enum FilterType
            {
                Online,
                Gamemode,
                Operator,
                Whitelist,
                Banned,
                Favorite
            }
        }

        public void ComputePlayersList(ref Player[] players)
        {
            Func<Player, bool> func;
            Func<Player, bool> tfunc;
            object a = ListFilter.Argument;

            switch (ListFilter.Type)
            {
                case PlayersFilter.FilterType.Online:
                    tfunc = (s) => s.Tags.Contains(Player.PlayerTag.Online);
                    if ((int)a == -1) func = (s) => !tfunc(s);
                    else func = tfunc;
                    break;

                case PlayersFilter.FilterType.Operator:
                    tfunc = (s) => s.Tags.Contains(Player.PlayerTag.Operator);
                    if ((int)a == -1) func = (s) => !tfunc(s);
                    else func = tfunc;
                    break;

                case PlayersFilter.FilterType.Banned:
                    tfunc = (s) => s.Tags.Contains(Player.PlayerTag.Banned);
                    if ((int)a == -1) func = (s) => !tfunc(s);
                    else func = tfunc;
                    break;

                case PlayersFilter.FilterType.Whitelist:
                    tfunc = (s) => s.Tags.Contains(Player.PlayerTag.Whitelisted);
                    if ((int)a == -1) func = (s) => !tfunc(s);
                    else func = tfunc;
                    break;

                case PlayersFilter.FilterType.Favorite:
                    tfunc = (s) => FavoritePlayers.Contains(s);
                    if ((int)a == -1) func = (s) => !tfunc(s);
                    else func = tfunc;
                    break;

                case PlayersFilter.FilterType.Gamemode:
                    var gm = (Gamemode)a;
                    func = (s) => s.GetCurrentGamemode() == gm;
                    break;

                default:
                    throw new Exception("ListFilter has invalid value");
            }

            players = players.Where(func).ToArray();
        }
    }
}
