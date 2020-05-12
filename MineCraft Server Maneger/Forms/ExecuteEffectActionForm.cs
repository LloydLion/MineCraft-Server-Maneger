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
    partial class ExecuteEffectActionForm : Form
    {
        public ExecuteEffectActionFormResult Result { get; private set; }

        public ExecuteEffectActionForm(string[] players, string[] playersList, string[] effects)
        {
            InitializeComponent();

            Font font = new Font("Meiryo UI", 11f, FontStyle.Bold);
            effects = effects.Append("Clear all effects").ToArray();

            players = players.Union(new string[] { "@a", "@r" }).ToArray();
            if (ServerManeger.GlobalManeger.MCVersion >= new MCVersion("1.8")) players = players.Append("@e").ToArray();

            ListViewItem[] items = playersList.Select((s) => new ListViewItem(s) { Font = font }).ToArray();

            playerList.Items.Clear();
            playerList.Items.AddRange(items);

            effectComboBox.Items.Clear();
            effectComboBox.Items.AddRange(effects);

            playersComboBox.Items.Clear();
            playersComboBox.Items.AddRange(players);
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            Result = new ExecuteEffectActionFormResult
            {
                Effect = new Effect(),
                Entities = ServerManeger.GlobalManeger.GetEntitiesBySelector(playersComboBox.Text)
            };

            if (effectComboBox.Text != "Clear all effects")
            {
                Result.Effect.EffectType = 
                    ServerManeger.GlobalManeger.GetEffectTypeByName(effectComboBox.Text);
                Result.Effect.HideParticiples = hideParticlesCheckBox.Checked;
                Result.Effect.Power = int.Parse(powerTextBox.Text);
                Result.Effect.Time = int.Parse(timeTextBox.Text);
            }
            else
            {
                Result.Effect.ClearEffects = true;
            }

            Close();
        }

        private void PlayerList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            playersComboBox.Text = e.Item.Text;
        }

        public class ExecuteEffectActionFormResult
        {
            public Entity[] Entities { get; set; }
            public Effect Effect { get; set; }
        }

        private void EffectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(((ComboBox)sender).Text == "Clear all effects")
            {
                timeTextBox.Text = "0";
                timeTextBox.Enabled = false;

                powerTextBox.Text = "0";
                powerTextBox.Enabled = false;

                hideParticlesCheckBox.Checked = false;
                hideParticlesCheckBox.Enabled = false;
            }
            else
            {
                timeTextBox.Enabled = true;
                powerTextBox.Enabled = true;
                hideParticlesCheckBox.Enabled = true;
            }
        }

        private void PowerTextBox_timeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(((TextBox)sender).Text, out _))
            {
                ((TextBox)sender).Text = string.Empty;
            }
        }
    }
}
