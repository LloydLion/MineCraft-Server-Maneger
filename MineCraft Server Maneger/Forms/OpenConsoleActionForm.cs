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
	partial class OpenConsoleActionForm : Form
	{
		private ConsoleManeger console;

		public OpenConsoleActionForm(ConsoleManeger console)
		{
			InitializeComponent();

			this.console = console;
		}

		private void UpdateConsoleTimer_Tick(object sender, EventArgs e)
		{
			consoleTextBox.Text = console.GetConsole();

			consoleTextBox.TextChanged += (q, w) =>
			{
				consoleTextBox.SelectionStart = consoleTextBox.Text.Length;
				consoleTextBox.ScrollToCaret();
			};

			consoleTextBox.ScrollBars = ScrollBars.Both;
		}

		private void runButton_Click(object sender, EventArgs e)
		{
			ServerManeger.GlobalManeger.ExecutePrimary(new Command(inputTextBox.Text));
			inputTextBox.Text = "";
		}
	}
}
