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
    partial class ExecuteGameruleActionForm : Form
    {
        private readonly Gamerule[] gamerules;
        public ExecuteGameruleActionForm(Gamerule[] gamerules)
        {
            InitializeComponent();
            comboBox1.Items.AddRange(gamerules.Select((s) => s.Name).ToArray());
            this.gamerules = gamerules;
        }

        public ExecuteGameruleActionFormResult Result { get; private set; }

        public class ExecuteGameruleActionFormResult
        {
            public Gamerule Selected { get; set; }
            public bool IsSet { get; set; }
            public object Value { get; set; }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var str = comboBox1.SelectedItem.ToString();
            var selected = gamerules.Where((s) => s.Name == str).Single();

            Result = new ExecuteGameruleActionFormResult()
            {
                Selected = selected,
                IsSet = comboBox2.SelectedIndex == 1,
                Value = comboBox2.SelectedIndex == 1 ? selected.ParseFunction(textBox.Text) : null
            };

            this.Close();
        }
    }
}
