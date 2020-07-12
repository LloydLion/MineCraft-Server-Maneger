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
	partial class ChangePlayerGamemodeActionForm : Form
	{
		public ChangePlayerGamemodeActionFormResult Result { get; private set; }

		public ChangePlayerGamemodeActionForm()
		{
			InitializeComponent();

			comboBox.Items.AddRange(Enum.GetValues(typeof(Gamemode)).OfType<Gamemode>().Except(new Gamemode[1] { Gamemode.Other }).Cast<object>().ToArray());
		}

		public class ChangePlayerGamemodeActionFormResult
		{
			public Gamemode SelectedGamemode { get; set; }
		}

		private void Button_Click(object sender, EventArgs e)
		{
			Result = new ChangePlayerGamemodeActionFormResult()
			{
				SelectedGamemode = (Gamemode)comboBox.SelectedItem
			};
		}
	}
}
