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
    partial class ExecuteTimeActionForm : Form
    {
        public ExecuteTimeActionFormResult Result { get; private set; }

        public ExecuteTimeActionForm()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox.Text, out _))
            {
                
            }
            else
            {
                textBox.Text = "";
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox.SelectedIndex >= 3 && comboBox.SelectedIndex <= 6)
            {
                textBox.Text = "";
                textBox.Enabled = false;
                button.Enabled = true;
            }
            else if (comboBox.SelectedIndex == 2)
            {
                button.Enabled = false;
                textBox.Text = "";
                textBox.Enabled = false;
            }
            else
            {
                textBox.Enabled = true;
                button.Enabled = true;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Result = new ExecuteTimeActionFormResult();


            if (comboBox.SelectedIndex >= 3 && comboBox.SelectedIndex <= 6)
            {
                Result.MainCommand = "Set";
                switch (comboBox.SelectedIndex)
                {
                    case 3:
                        Result.Time = 1000;
                        break;
                    case 4:
                        Result.Time = 13000;
                        break;
                    case 5:
                        Result.Time = 6000;
                        break;
                    case 6:
                        Result.Time = 18000;
                        break;
                }
            }
            else
            {
                Result.MainCommand = comboBox.Text;
                Result.Time = int.Parse(textBox.Text);
            }

            this.Close();
        }

        public class ExecuteTimeActionFormResult
        {
            public string MainCommand { get; set; }
            public int Time { get; set; }
        }
    }
}
