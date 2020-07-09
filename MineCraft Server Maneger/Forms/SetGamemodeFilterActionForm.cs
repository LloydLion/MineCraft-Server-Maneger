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
	partial class SetGamemodeFilterActionForm : Form
	{
		public class SetGamemodeFilterActionFormResult
		{
			public Gamemode Gamemode { get; set; }
		}

		public SetGamemodeFilterActionFormResult Result { get; private set; }

		public SetGamemodeFilterActionForm()
		{
			InitializeComponent();

			comboBox.Items.AddRange(Enum.GetValues(typeof(Gamemode))
				.OfType<Gamemode>().Select((s) => s.ToString()).ToArray());
		}

		private void Button_Click(object sender, EventArgs e)
		{
			Result = new SetGamemodeFilterActionFormResult()
			{
				Gamemode = Enum.GetValues(typeof(Gamemode))
				.OfType<Gamemode>().Where((s) => s.ToString() == comboBox.Text)
				.Single()
			};

			this.Close();
		}
	}
}
