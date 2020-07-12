//#define SHOW

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MineCraft_Server_Maneger.Models;

namespace MineCraft_Server_Maneger
{
	partial class MainForm : Form
	{
		private readonly Process serverProcess;
		private readonly ServerInfo serverInfo;
		private readonly ServerStade stade = new ServerStade();
		private readonly ServerManeger maneger;
		private readonly UIManeger uimaneger;
		private readonly ActionBase[] actions;

		public MainForm(ServerInfo info)
		{
			InitializeComponent();
			serverInfo = info;
			if (info != null)
			{
				serverProcess = new Process
				{
#if SHOW
					StartInfo = new ProcessStartInfo("java", $"-jar \"core.jar\"")
					{
						UseShellExecute = true,
						WorkingDirectory = Static.Path.data,
						RedirectStandardInput = false,
						RedirectStandardOutput = false,
						RedirectStandardError = false
					}
#else
					StartInfo = new ProcessStartInfo("javaw", $"-jar \"core.jar\"")
					{
						UseShellExecute = false,
						WorkingDirectory = Static.Path.data,
						RedirectStandardInput = true,
						RedirectStandardOutput = true,
						RedirectStandardError = true
					}
#endif
				};

				File.Copy(info.Path, $"{Static.Path.data}\\core.jar", true);
				stade.IsSelected = true;
			}
			else
			{
				stade.IsSelected = false;
			}

			maneger = new ServerManeger(serverProcess, info.GameVersion);
			uimaneger = new UIManeger(commandsOutputTextBox, commandsInputTextBox, filtratedPlayersListView);

			uimaneger.ListFilter.Type = UIManeger.PlayersFilter.FilterType.Online;
			uimaneger.ListFilter.Argument = 0;

			actions = Assembly.GetExecutingAssembly().GetTypes().Where
				((d) => d.Namespace == this.GetType().Namespace + ".Actions" &&
						d.BaseType == typeof(ActionBase) &&
						d.GetConstructor(new Type[0]) != null).Select
				((f) => (ActionBase)f.GetConstructor(new Type[0]).Invoke(new object[0])).ToArray();

			actions = actions.Select((a) =>
			{
				a.ServerInfo = serverInfo;
				a.ServerStade = stade;

				return a;
			}).ToArray();

			var buttons = this.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
				.Where((f) => f.Name.EndsWith(nameof(Button)) &&
				f.FieldType == typeof(Button)).ToArray();

			foreach (var g in actions)
			{
				//g.Controls = g.ControlsNames.Select((f) => (Control)this.GetType()
				//    .GetField(f, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance).GetValue(this))
				//    .ToArray();

				var name = g.ActionName;
				var split = name.Split('.');
				var el1 = split[0];
				var el2 = split[1];

				var el2split = el2.Split('_');



				foreach (var b in buttons)
				{
					var p = Regex.Replace(b.Name, "([A-Z])", ".$1").Split('.');
					p = p.Select((f) => f.ToLower()).ToArray();
					var t = new string[p.Length - 2];
					t = t.Select((_3, s) => p[s + 1]).ToArray();

					if (p[0] == el1 && el2split.Length == t.Length &&
						Array.TrueForAll(el2split.Select((q, s) => q == t[s]).ToArray(), (s) => s))
					{
						((Button)b.GetValue(this)).Click += (_1, _2) => g.Handler();
						stade.PropertyChanged += (_1, _2) => { ((Button)b.GetValue(this)).Enabled = g.IsEnabled(); };
						stade.InvokeEventPropertyChanged();
						break;
					}
				}
			}


			commandsOutputTextBox.TextChanged += (sender, e) =>
			{
				commandsOutputTextBox.SelectionStart = commandsOutputTextBox.TextLength;
				commandsOutputTextBox.ScrollToCaret();
			};
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (stade.IsRunnning == true)
			{
				MessageBox.Show("Server is running.\nIt is closing automaticly");
				maneger.Stop();
				stade.IsRunnning = false;
			}

			e.Cancel = false;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			if (!stade.IsDoneStarted) return;

			var players = maneger.AllPlayers;

			uimaneger.ComputePlayersList(ref players);

			filtratedPlayersListView.Items.Clear();
			filtratedPlayersListView.Items.AddRange
				(players.Select((s) => new ListViewItem(s.Name)).ToArray());
		}
	}
}
