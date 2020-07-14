using MineCraft_Server_Maneger.Actions;
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
	partial class TeleportPlayerActionForm : Form
	{
		public TeleportPlayerActionFormResult Result { get; private set; }

		private Player[] players;

		public TeleportPlayerActionForm(Player[] players)
		{
			InitializeComponent();

			this.players = players;

			playerComboBox.Items.AddRange(players);
			playerList.Items.AddRange(players.Select((s) => new ListViewItem(s.Name)).ToArray());
		}

		public class TeleportPlayerActionFormResult
		{
			public bool IsToPlayer { get; set; }
			public Player Target { get; set; }
			public (float x, float y, float z) Position { get; set; }
		}

		private void ExecuteButton_Click(object sender, EventArgs e)
		{
			Result = new TeleportPlayerActionFormResult()
			{
				IsToPlayer = radioButton1.Checked
			};

			if(Result.IsToPlayer == true)
			{
				Result.Target = (Player)playerComboBox.SelectedItem;
			}
			else
			{
				Result.Position = (float.Parse(xPositionTextBox.Text), float.Parse(yPositionTextBox.Text), float.Parse(zPositionTextBox.Text));
			}

			this.Close();
		}

		private void RadioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if(radioButton2.Checked == true)
			{
				playerList.Enabled = false;
				playerComboBox.Enabled = false;

				xPositionTextBox.Enabled = yPositionTextBox.Enabled = zPositionTextBox.Enabled = true;
			}
			else
			{
				playerList.Enabled = true;
				playerComboBox.Enabled = true;

				xPositionTextBox.Enabled = yPositionTextBox.Enabled = zPositionTextBox.Enabled = false;
			}
		}

		private void PlayerList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			playerComboBox.SelectedItem = players.Single((s) => s.Name == e.Item.Text);
		}
	}
}
